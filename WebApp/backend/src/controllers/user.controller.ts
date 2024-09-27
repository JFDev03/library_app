import executeQuery from "../utils/executeQuery.util";
import { Request,Response } from "express";
import { getAllBooksWithPaginations,getBook, getBorrowedBooks } from "../services/func.service";
import {BorrowDataT, booksDataT} from "../types/user.types"

export const getBooks = (req:Request,res:Response)=>{
    return getAllBooksWithPaginations(req,res)
}
export const getBookSpecific = (req:Request,res:Response)=>{
    return getBook(req,res)
}

export const getAllBorrowedBooks = (req:Request,res:Response)=>{
    return getBorrowedBooks(req,res)
}

export const borrowFunc = async(req:Request,res:Response)=>{
    const {employee_id} = req.body.user
    const {book_id} = req.body
    try {
        const checkQuery = `SELECT * FROM borrow_table WHERE employee_id = ? AND book_unique_id = ? AND status = 'borrowed'`
        const result = await executeQuery(checkQuery,[employee_id,book_id]) as Array<BorrowDataT>
        if(result.length > 0){
           return res.status(403).send({
                message:"You have already Borrow this book"
            })
        }
        const getBookData =  `SELECT * FROM books_table
        WHERE book_unique_id = ?`

        const [book] = await executeQuery(getBookData,[book_id]) as Array<booksDataT>

        if(book.initial_quantity <=0){
            return res.status(403).send({
                message:"these books have already borrowed"
            })
        }

        const insertQuery = `INSERT INTO borrow_table(employee_id,book_unique_id,quantity,status)VALUES(?,?,1,'borrowed')`

        const response = await executeQuery(insertQuery,[employee_id,book_id])
        if(!response){
            return res.status(403).send({
                message:"Error Inserting"
            })
        }

        const newInitialQuantity = book.initial_quantity - 1

        const updateQuery = `UPDATE books_table SET initial_quantity = ? WHERE book_unique_id = ?`
        const finalresponse = await executeQuery(updateQuery,[newInitialQuantity,book_id])
        if(finalresponse){
            return res.status(200).send({
                message:"Success Fully Borrowed"
            })
        }
    } catch (error) {
        console.error(error); // Log detailed error for debugging
        return res.status(500).send({ message: "Something went wrong with the database." });
    }
}

