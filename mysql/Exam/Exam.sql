create database Exam;

use Exam;

create table authors (
	author_id int primary key auto_increment,
    author_name varchar(100) not null
);

create table categories (
	category_id int primary key auto_increment,
    category_name varchar(100) not null unique
);

create table books (
	book_id int primary key auto_increment,
    title varchar(100) not null,
	author_id int not null,
    category_id int not null,
    foreign key(author_id) references authors(author_id),
    foreign key(category_id) references categories(category_id)
);

create table borrowings(
	borrowing_id int primary key auto_increment,
    book_id int not null,
    borrowed_date date not null,
    returned_date date
);

INSERT INTO authors (author_name) VALUES 
('Stephen King'),
('J.K. Rowling'),
('George Orwell'),
('Harper Lee');

INSERT INTO categories (category_name) VALUES 
('Horror'),
('Fantasy'),
('Dystopian'),
('Classics');

INSERT INTO books (title, author_id, category_id) VALUES 
('Test', 1, 1),
('Carrie', 1, 1),
('The Stand', 1, 2),
('Misery', 1, 3),
('It', 1, 4),
('The Dark Tower: The Gunslinger', 1, 1),
('Pet Sematary', 1, 2),
('The Green Mile', 1, 3),    
('Harry Potter and the Order of the Phoenix', 2, 2),
('Harry Potter and the Half-Blood Prince', 2, 2),
('Harry Potter and the Deathly Hallows', 2, 2),
('Fantastic Beasts and Where to Find Them', 2, 2),
('Quidditch Through the Ages', 2, 1),
('The Tales of Beedle the Bard', 2, 2),
('The Casual Vacancy', 2, 3), 
('Animal Farm', 3, 3),
('Homage to Catalonia', 3, 4),
('Down and Out in Paris and London', 3, 1),
('Burmese Days', 3, 2),
('Keep the Aspidistra Flying', 3, 3),
('The Road to Wigan Pier', 3, 4),
('Coming Up for Air', 3, 1),
('Go Set a Watchman', 4, 4),
('To Kill a Mockingbird', 4, 1),
('To Kill a Mockingbird (graphic novel)', 4, 2),
('The Watchman', 4, 3),
('Scout, Atticus, and Boo: A Celebration of Fifty Years of To Kill a Mockingbird', 4, 4),
('The Mockingbird Next Door: Life with Harper Lee', 4, 1);
 
INSERT INTO borrowings (book_id, borrowed_date, returned_date) VALUES 
(1, '2024-04-01', '2024-04-15'),
(2, '2024-03-20', '2024-04-10'),
(3, '2024-03-25', '2024-04-05'),
(4, '2024-04-05', NULL),
(5, '2024-03-15', NULL),
(6, '2024-03-10', NULL),
(7, '2024-04-10', NULL),
(8, '2024-03-05', '2024-04-18'),
(9, '2024-04-02', NULL),
(10, '2024-03-30', '2024-04-12'),
(11, '2024-04-12', NULL),
(12, '2024-04-15', NULL),
(13, '2024-03-18', '2024-04-08'),
(14, '2024-04-08', NULL),
(15, '2024-04-02', '2024-04-20'),
(16, '2024-03-27', NULL),
(17, '2024-03-23', NULL),
(18, '2024-04-10', NULL),
(19, '2024-04-01', NULL),
(20, '2024-04-05', NULL),
(21, '2024-03-28', NULL),
(22, '2024-04-20', '2024-04-20'),
(23, '2024-04-03', NULL),
(24, '2024-03-25', '2024-04-14'),
(25, '2024-03-17', NULL),
(26, '2024-03-21', '2024-04-16'),
(27, '2024-04-10', NULL);

-- Вывести всех авторов.
select author_id AS 'Id', author_name AS 'Name' from authors;

-- Вывести все категории.
select category_id AS 'Id', category_name AS 'Name' from categories;

-- Вывести список всех книг.
select * from books;

-- Вывести список всех книг с именами их авторов.
use exam;
select 
	books.book_id as 'Id',
    books.title as 'Title',
    authors.author_name as 'Author',  
    categories.category_name as 'Genre'
from books
join authors on books.author_id = authors.author_id
join categories on books.category_id = categories.category_id;

-- Вывести список книг, которые были выданы, но еще не возвращены.
use exam;
select 
	books.book_id as 'Id',
    books.title as 'Title',
    authors.author_name as 'Author',  
    categories.category_name as 'Genre',
    borrowings.borrowed_date as 'Borrowed Date'    
from books
join authors on books.author_id = authors.author_id
join categories on books.category_id = categories.category_id
join borrowings on books.book_id = borrowings.book_id
where borrowings.returned_date is null;

-- Вывести список всех книг в категории "Classic".
use exam;
select 
	books.book_id as 'Id',
    books.title as 'Title',
    authors.author_name as 'Author'
from books
join authors on books.author_id = authors.author_id
join categories on books.category_id = categories.category_id
where categories.category_name = 'Classics';

-- Вывести количество книг каждого автора.
use exam;
select 
	authors.author_name as 'Author',
    count(*) as 'Amount books'
from books
join authors on books.author_id = authors.author_id
group by authors.author_name;

-- Вывести последние три записи о выдаче книг.
select 
	exam.books.title as 'Book',
    exam.authors.author_name as 'Author',
    exam.categories.category_name as 'Genre',
    exam.borrowings.borrowed_date as 'Borrowed date',
    exam.borrowings.returned_date as 'Returned date'
from exam.borrowings
join exam.books on exam.books.book_id = exam.borrowings.book_id
join exam.authors on exam.books.author_id = exam.authors.author_id
join exam.categories on exam.books.category_id = exam.categories.category_id
order by exam.borrowings.borrowing_id desc
limit 3;

-- Вывести список книг, которые были возвращены.
use exam;
select 
	books.book_id as 'Id',
    books.title as 'Title',
    authors.author_name as 'Author',  
    categories.category_name as 'Genre',
    borrowings.borrowed_date as 'Borrowed Date',    
    borrowings.returned_date as 'Returned date'
from books
join authors on books.author_id = authors.author_id
join categories on books.category_id = categories.category_id
join borrowings on books.book_id = borrowings.book_id
where borrowings.returned_date is not null;

-- Вывести авторов с количеством книг больше одной.
use exam;
select 
	authors.author_name as 'Author',
    count(*) as 'Amount books'
from books
join authors on books.author_id = authors.author_id
group by authors.author_name
having count(*) > 1;

-- Вывести список книг, взятых на прочтение более чем на месяц.
select 
	exam.books.title as 'Book',
    exam.authors.author_name as 'Author',
    exam.categories.category_name as 'Genre',
    exam.borrowings.borrowed_date as 'Borrowed date',
    exam.borrowings.returned_date as 'Returned date'
from exam.borrowings
join exam.books on exam.books.book_id = exam.borrowings.book_id
join exam.authors on exam.books.author_id = exam.authors.author_id
join exam.categories on exam.books.category_id = exam.categories.category_id
where datediff(exam.borrowings.returned_date, exam.borrowings.borrowed_date) > 30;

-- Вывести список книг, которые были выданы, но не были возвращены, с группировкой по категориям.
select
    exam.categories.category_name as 'Genre',
    count(*) as 'Amount'
from exam.borrowings
join exam.books on exam.books.book_id = exam.borrowings.book_id
join exam.authors on exam.books.author_id = exam.authors.author_id
join exam.categories on exam.books.category_id = exam.categories.category_id
where exam.borrowings.returned_date is null
group by exam.categories.category_name;

-- Вывести список авторов и количество их книг, которые были выданы за последний год.
select
    exam.authors.author_name as 'Author',
    count(*) as 'Amount'
from exam.authors
join exam.books on exam.books.author_id = exam.authors.author_id
join exam.categories on exam.books.category_id = exam.categories.category_id
join exam.borrowings on exam.borrowings.book_id = exam.books.book_id
where exam.borrowings.borrowed_date >= date_sub(current_date(), interval 1 year)
group by exam.authors.author_name;

-- Вывести список книг, которые никогда не были выданы.
use exam;
select 
	books.book_id as 'Id',
    books.title as 'Title',
    authors.author_name as 'Author',  
    categories.category_name as 'Genre'    
from books
join authors on books.author_id = authors.author_id
join categories on books.category_id = categories.category_id
left join borrowings on books.book_id = borrowings.book_id
where borrowings.borrowed_date is null;

-- (первый вариант) Вывести список категорий и количество книг в каждой категории, которые были выданы и возвращены в этом году.
select	
    exam.categories.category_name as 'Genre',
    count(*) as 'Amount'
from exam.borrowings
join exam.books on exam.books.book_id = exam.borrowings.book_id
join exam.categories on exam.books.category_id = exam.categories.category_id
where exam.borrowings.borrowed_date >= date_format(current_date(), '%Y-01-01') and
	  exam.borrowings.borrowed_date <= date_format(current_date(), '%Y-12-31') and
      exam.borrowings.returned_date is not null
group by exam.categories.category_name;

-- (второй вариант) Вывести список категорий и количество книг в каждой категории, которые были выданы и возвращены в этом году.
select	
    exam.categories.category_name as 'Genre',
    count(*) as 'Amount'
from exam.borrowings
join exam.books on exam.books.book_id = exam.borrowings.book_id
join exam.categories on exam.books.category_id = exam.categories.category_id
where year(exam.borrowings.returned_date) = year(curdate())
group by exam.categories.category_name;
