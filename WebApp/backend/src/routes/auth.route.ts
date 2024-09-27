import express from "express";
import { createUser,loginUser,Token,logout } from "../controllers/auth.controller";
import verifyToken from "../middlewares/verifyToken.middleware";
import { upload } from "../middlewares/uploadImage.middleware";
const auth = express.Router()

auth.post('/create-user',upload.single('profile_picture'),createUser)
auth.post('/login',loginUser)
auth.post('/refresh-token',Token)
auth.post('/logout',verifyToken,logout)

export default auth