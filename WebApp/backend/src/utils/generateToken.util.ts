import executeQuery from "./executeQuery.util";
import config from "./config.util";
import jwt from 'jsonwebtoken'



export const generateRefreshToken = async(thisid:string)=>{
    try {
        const refreshToken = jwt.sign(
            { employee_id: thisid },
            config.server.token.refreshSecret,
            { expiresIn: config.server.token.refreshTokenExpireTime }
        );
    
    
        const insertRefreshTokenQuery = 'INSERT INTO jwt_table(employee_id, refresh_token) VALUES (?, ?)';
        await executeQuery(insertRefreshTokenQuery, [thisid, refreshToken]);
    
        return refreshToken;
    } catch (error) {
        console.error('Error generating refresh token:', error);
        throw error; // or handle the error as needed
    }
    
}

export const generateAccessToken = (thisid:string)=>{
    return jwt.sign(
        {employee_id:thisid},config.server.token.accessSecret,
        {expiresIn:config.server.token.accessTokenExpireTime}
    );
}

export const getRefreshTokenValue = (token:string)=>{
    return jwt.verify(token,config.server.token.refreshSecret)
}