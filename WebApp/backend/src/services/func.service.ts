import executeQuery from "../utils/executeQuery.util";
import { Request,Response } from "express";
import { booksDataT, totalPagesQuery } from "../types/user.types";

export const getBook =async (req:Request,res:Response) => {
    try {
        const book_unique_id = req.query.book_unique_id as string;
        const query = `SELECT * FROM books_table
        WHERE book_unique_id = ?`
          const [books] = await executeQuery(query,[book_unique_id]) as Array<booksDataT>
          if(books){
            return res.status(200).send({
                book:books,
            })
          }
    } catch (error) {
        return res.status(500).send({ message: "Something went wrong with the database." });
    }
}

export const getAllBooksWithPaginations = async (req:Request,res:Response)=>{
    try {
        const page = parseInt(req.query.page as string) || 1; // default to page 1
        const limit = parseInt(req.query.limit as string) || 5;
        const searchTerm = req.query.search ? `%${req.query.search}%` : '%%'; // if no searchTerm, match all
        const offset = (page - 1) * limit;

        const totalQuery = `SELECT Count(*) as total FROM books_table
        WHERE book_unique_id LIKE ? 
           OR book_name LIKE ? 
           OR author LIKE ? 
           OR genre LIKE ?
        `

        const totalResult = await executeQuery(totalQuery, [searchTerm,searchTerm,searchTerm,searchTerm]) as Array<totalPagesQuery>;
        const total = totalResult[0].total;
        const totalPage = Math.ceil(total/limit)

        const query = `SELECT * FROM books_table
        WHERE book_unique_id LIKE ? 
           OR book_name LIKE ? 
           OR author LIKE ? 
           OR genre LIKE ? 
        ORDER BY id DESC 
        LIMIT ?, ?`
          const books = await executeQuery(query,[searchTerm,searchTerm,searchTerm,searchTerm,offset,limit])

          if(books){
            return res.status(200).send({
                books:books,
                current_page:page,
                last_page:totalPage,
                limit:limit
            })
          }
    } catch (error) {
        return res.status(500).send({ message: "Something went wrong with the database." });
    }
}
export const getBorrowedBooks =async (req:Request,res:Response) => {
    try {
        const {employee_id} = req.body.user
        const page = parseInt(req.query.page as string) || 1; // default to page 1
        const limit = parseInt(req.query.limit as string) || 5;
        const searchTerm = req.query.search ? `%${req.query.search}%` : '%%'; // if no searchTerm, match all
        const offset = (page - 1) * limit;
        console.log(page,limit,searchTerm)

        const totalQuery = `SELECT COUNT(*) as total 
        FROM borrow_table a 
        LEFT OUTER JOIN books_table b 
        ON b.book_unique_id = a.book_unique_id 
        WHERE (b.book_unique_id LIKE ? OR
               b.book_name LIKE ? OR
               b.author LIKE ? OR 
               b.genre LIKE ?)
        AND a.employee_id = ?
        
        `
        const totalResult = await executeQuery(totalQuery, [searchTerm,searchTerm,searchTerm,searchTerm,employee_id]) as Array<totalPagesQuery>;
        const total = totalResult[0].total;
        const totalPage = Math.ceil(total/limit)

        const query = `SELECT a.id, b.book_unique_id, b.book_image, b.book_name, b.book_desc, 
        b.author, b.date_published, b.genre, a.quantity, a.status 
 FROM borrow_table a 
 LEFT OUTER JOIN books_table b 
 ON b.book_unique_id = a.book_unique_id 
 WHERE (b.book_unique_id LIKE ? OR
        b.book_name LIKE ? OR
        b.author LIKE ? OR 
        b.genre LIKE ?)
 AND a.employee_id = ? 
 ORDER BY a.id DESC 
 LIMIT ?, ?
 `
          const books = await executeQuery(query,[searchTerm,searchTerm,searchTerm,searchTerm,employee_id,offset,limit])

          if(books){
            return res.status(200).send({
                books:books,
                current_page:page,
                last_page:totalPage,
                limit:limit
            })
          }
    } catch (error) {
        return res.status(500).send({ message: "Something went wrong with the database." });
        
    }
}