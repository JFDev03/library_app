import executeQuery from "../utils/executeQuery.util";
import { Request,Response } from "express";
import bcrypt from 'bcryptjs'
import { userDataT,userLoginT } from "../types/user.types";
import { generateAccessToken,generateRefreshToken,getRefreshTokenValue } from '../utils/generateToken.util';
import { JwtPayload } from 'jsonwebtoken';


export const createUser = async (req: Request, res: Response) => {
    const { employee_id, password, confirm_password, firstname, lastname, middlename, position } = req.body;
    const files = req.file as { [fieldname: string]: Express.Multer.File[] } | undefined;
  console.log(files)
    if (!files) { // Check for req.file directly
        return res.status(400).send({ message: "Profile picture is required." });
      }
    const checkingQuery = 'SELECT employee_id FROM user_info_table WHERE employee_id = ?';
    const insertQueryUsertbl = 'INSERT INTO user_table(employee_id, password) VALUES (?, ?)';
    const insertQueryUserInfo = 'INSERT INTO user_info_table (employee_id, profile_picture, firstname, lastname, middlename, position) VALUES (?, ?, ?, ?, ?, ?)';
  
    try {
      if (password !== confirm_password) {
        return res.status(403).send({ message: "Passwords do not match" });
      }
  
      const [existUser] = await executeQuery(checkingQuery, [employee_id]) as Array<userDataT>;
      if (existUser) {
        return res.status(403).send({ message: "Username is already in use" });
      } else {
        if (!password) {
          return res.status(400).send({ message: "Password is required" });
        }
  
        const hashedPassword = await bcrypt.hash(password, 10);
        const userInsertResponse = await executeQuery(insertQueryUsertbl, [employee_id, hashedPassword]);
  
        if (!userInsertResponse) {
          return res.status(403).send({ message: "Error in user creation" });
        }
  
        const profilePath = `upload\\${files.filename}`;
        const userInfoResponse = await executeQuery(insertQueryUserInfo, [employee_id, profilePath, firstname, lastname, middlename, position]);
  
        if (userInfoResponse) {
          return res.status(201).send({ message: "User created successfully" });
        }
      }
    } catch (error) {
      console.error(error); // Log detailed error for debugging
      return res.status(500).send({ message: "Something went wrong with the database." });
    }
  };

export const loginUser =async (req:Request,res:Response) => {
    try {
        const {employee_id,password}:userLoginT = req.body
        const CheckingQuery = `SELECT 
        a.id, 
        a.employee_id, 
        a.password, 
        a.role, 
        b.profile_picture, 
        CONCAT_WS(" ", COALESCE(b.firstname, ''), COALESCE(b.middlename, ''), COALESCE(b.lastname, '')) AS fullname, 
        b.position, 
        b.status 
    FROM 
        user_table a
    JOIN 
        user_info_table b ON a.employee_id = b.employee_id
    WHERE 
        a.employee_id = ?`
    
        const [user] = await executeQuery(CheckingQuery,[employee_id,password]) as Array<userDataT>
        if (!user) {
            return res.status(409).send({ message: "User does not exist!" });
        }

        const isPasswordValid = await bcrypt.compare(password.toString(), user.password);
        if (!isPasswordValid) {
            return res.status(400).send({ message: "Password is incorrect" });
        }
        const thisaccessToken = generateAccessToken(user.employee_id);
        const thisrefreshToken = await generateRefreshToken(user.employee_id);

        return res.status(200).send({
            message: 'Login Successful',
            accessToken:thisaccessToken,
            refreshToken:thisrefreshToken,
            user: {
                profile_picture:user.profile_picture,
                fullname: user.fullname,
                role:user.role,
            }
        });
    } catch (error) {
        console.error(error); // Log detailed error for debugging
        return res.status(500).send({ message: "Something went wrong with the database." });
    }
}

export const Token = async(req:Request,res:Response)=>{
    try {
        const {refreshToken} = req.body;
        const checkTokenQuery = 'SELECT refresh_token FROM jwt_table WHERE refresh_token = ?'
        const getToken = await executeQuery(checkTokenQuery,[refreshToken]);

        if(!getToken){
            return res.status(404).send({message:'Token Invalid'})
        }
        const decoded = getRefreshTokenValue(refreshToken);
        
        if (typeof decoded === 'string') {
            return res.status(400).send({ message: 'Invalid token format' });
        }

        const payload = decoded as JwtPayload;
        const accessToken = generateAccessToken(payload.employee_id);

        const CheckingQuery = `SELECT 
        a.id, 
        a.employee_id, 
        a.password, 
        a.role, 
        b.profile_picture, 
        CONCAT_WS(" ", COALESCE(b.firstname, ''), COALESCE(b.middlename, ''), COALESCE(b.lastname, '')) AS fullname, 
        b.position, 
        b.status 
    FROM 
        user_table a
    JOIN 
        user_info_table b ON a.employee_id = b.employee_id
    WHERE 
        a.employee_id = ?`
        const [user] = await executeQuery(CheckingQuery, [payload.employee_id]) as Array<userDataT>;
        if(!accessToken){
            return res.status(404).send({message:'Error Generating AccessToken'})
        }
        return res.status(201).send({
            message: 'Access Token Generated Successfully',
            accessToken:accessToken,
            user: {
                profile_picture:user.profile_picture,
                fullname: user.fullname,
                role:user.role,
            }
        })

    } catch (error) {
        console.error("Database Error: ", error); // Log detailed error for debugging
        return res.status(500).send({ message: "Something went wrong with the database." });
    }
}
export const logout = async(req:Request,res:Response)=>{
    try {
        const userAuth = req.body.user;
        console.log(userAuth)
        const DeleteQuery = 'DELETE FROM jwt_table WHERE employee_id = ?'
        const result = await executeQuery(DeleteQuery,[userAuth.employee_id]);
        if(!result){
            return res.status(404).send({message:'User Not Found'})
        }
        return res.status(200).send({message:'User Successfully Logout'})
    } catch (error) {
        console.error("Database Error: ", error); // Log detailed error for debugging
        return res.status(500).send({ message: "Something went wrong with the database." });
    }
}