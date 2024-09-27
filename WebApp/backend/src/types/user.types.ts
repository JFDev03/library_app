export interface userDataT{
    id:number
    employee_id:string
    password:string
    role:string
    profile_picture:string
    fullname:string
    position:string
    status:string
}
export interface userLoginT{
    employee_id:string
    password:string
}
export interface booksDataT{
    id:number
    book_unique_id:string
    book_image:string
    book_name:string
    book_desc:string
    author:string
    date_published:string
    genre:string
    initial_quantity:number
    total_quantity:number
}
export interface totalPagesQuery{
    total:number
}
export interface BorrowDataT{
    id:number
    employee_id:string
    book_unique_id:string
    quantity:number
    status:number
    date_borrowed:string
    date_returned:string
}