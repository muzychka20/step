CREATE DATABASE Shop;

SET SQL_SAFE_UPDATES = 0;

USE Shop;

CREATE TABLE Products(
	id INT PRIMARY KEY AUTO_INCREMENT,
    name_product VARCHAR(50),
    category VARCHAR(50),
    price INT,
    amount INT,
    supplier VARCHAR(50)
);

INSERT INTO Products (name_product, category, price, amount, supplier) VALUES
('Laptop Asus', 'Electronics', 50, 80, 'FashionHut'),
('Vacuum Cleaner', 'Appliances', 50, 80, 'FashionHut'),
('Ball', 'Sporting Goods', 50, 80, 'FashionHut'),
('Pen', 'Stationery', 50, 80, 'FashionHut'),
('Smartphone', 'Electronics', 800, 50, 'TechMart'),
('Running Shoes', 'Sporting Goods', 120, 100, 'SportZone'),
('Coffee Maker', 'Appliances', 150, 30, 'HomeTech'),
('Leather Wallet', 'Accessories', 50, 80, 'FashionHut'),
('Notebook', 'Stationery', 10, 200, 'OfficeSupplies'),
('Laptop', 'Electronics', 1200, 30, 'TechMart'),
('Basketball', 'Sporting Goods', 25, 50, 'SportZone'),
('Microwave Oven', 'Appliances', 200, 20, 'HomeTech'),
('Leather Belt', 'Accessories', 40, 70, 'FashionHut'),
('Printer', 'Stationery', 150, 25, 'OfficeSupplies'),
('Smart TV', 'Electronics', 1000, 20, 'TechMart'),
('Soccer Ball', 'Sporting Goods', 30, 40, 'SportZone'),
('Refrigerator', 'Appliances', 800, 15, 'HomeTech'),
('Scarf', 'Accessories', 20, 60, 'FashionHut'),
('Printer Paper', 'Stationery', 20, 100, 'OfficeSupplies'),
('Bluetooth Speaker', 'Electronics', 150, 25, 'TechMart'),
('Yoga Mat', 'Sporting Goods', 35, 30, 'SportZone'),
('Toaster', 'Appliances', 50, 25, 'HomeTech'),
('Sunglasses', 'Accessories', 30, 50, 'FashionHut'),
('Ballpoint Pen', 'Stationery', 5, 200, 'OfficeSupplies');

-- Выборка всех товаров определенной категории
-- Напишите запрос для выборки всех товаров категории "электроника".	
SELECT * 
FROM Products
WHERE category = 'Electronics';

-- Выборка товаров по диапазону цен
-- Сформулируйте запрос для выбора всех товаров, цена которых находится в диапазоне от 50 до 150 единиц валюты.
SELECT * 
FROM Products
WHERE price BETWEEN 50 AND 150;


-- Обновление количества товара
-- Обновите количество на складе для конкретного товара, используя его ProductID. Предположим, что нужно обновить количество для товара с ProductID равным 2.
UPDATE Products 
SET amount = 20
WHERE id = 2;

-- Удаление записи о товаре
-- Удалите информацию о товаре по его названию. Предположим, что нужно удалить запись для товара "Bluetooth наушники".
DELETE FROM Products 
WHERE name_product = 'Notebook';

-- Выборка товаров с количеством меньше указанного
-- Выберите из таблицы все товары, количество которых на складе меньше 30 единиц.
SELECT * 
FROM Products
WHERE amount < 30;

-- Сортировка товаров по цене
-- Отсортируйте товары по цене в порядке убывания.
SELECT * 
FROM Products
ORDER BY price DESC;

-- Выборка трех самых дорогих товаров каждой категории
-- Напишите запрос для выбора трех самых дорогих товаров в каждой категории.
SELECT *
FROM Products p1
WHERE 
	(
		SELECT COUNT(*)
		FROM Products p2
		WHERE p1.category = p2.category 
        AND p1.price <= p2.price
	) <= 3
ORDER BY category, price DESC;

-- Подсчет количества товаров каждого поставщика
-- Подсчитайте, сколько товаров предоставлено каждым поставщиком.
SELECT supplier, COUNT(*)
FROM Products
GROUP BY supplier;

-- Выборка товаров определенного поставщика с минимальным количеством на складе
-- Сформулируйте запрос для выбора всех товаров поставщика "Supplier X", количество которых на складе не превышает 27 единиц.
SELECT *
FROM Products
WHERE supplier = 'TechMart'
AND amount < 27;

-- Выборка поставщиков, которые предоставляют товары во всех категориях.
SELECT supplier
FROM Products
GROUP BY supplier
HAVING COUNT(DISTINCT category) = (SELECT COUNT(DISTINCT category) FROM Products);

-- Выборка категорий товаров с максимальным и минимальным количеством товаров в каждой категории
SELECT category, MAX(amount) AS 'Макс количество', MIN(amount) AS 'Мин  количество'
FROM Products
GROUP BY category;

-- Выборка товаров среди тех, у которых цена выше средней цены в каждой категории:
SELECT *
FROM Products p1
WHERE price > (
    SELECT AVG(price)
    FROM Products p2
    WHERE p1.category = p2.category
)
ORDER BY category, price DESC;
