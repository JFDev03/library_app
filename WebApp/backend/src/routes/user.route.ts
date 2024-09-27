import express from "express";
import { getBooks,getBookSpecific,borrowFunc, getAllBorrowedBooks } from "../controllers/user.controller";
import verifyToken from "../middlewares/verifyToken.middleware";

const user = express.Router()

user.get('/getAllBooks',getBooks)
user.get('/getBook',getBookSpecific)
user.get('/getAllBorrowedBooks',verifyToken,getAllBorrowedBooks)
user.post('/borrowBook',verifyToken,borrowFunc)

export default user