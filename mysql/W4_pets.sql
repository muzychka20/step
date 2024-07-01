CREATE TABLE Pets(
	id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(50),
    age INT,
    species VARCHAR(50),
    color VARCHAR(50),
    weight INT,
    type VARCHAR(50)
);

INSERT INTO Pets (name, age, species, color, weight, type) VALUES
('Lucky', 7, 'Labrador', 'Brown', 13, 'Dog'),
('Max', 3, 'Labrador', 'Brown', 10, 'Dog'),
('Bella', 2, 'Persian', 'White', 5, 'Cat'),
('Charlie', 5, 'German Shepherd', 'Black', 12, 'Dog'),
('Lucy', 1, 'Dwarf', 'Gray', 2, 'Rabbit'),
('Buddy', 4, 'Golden Retriever', 'Golden', 8, 'Dog'),
('Luna', 3, 'Siamese', 'Gray', 6, 'Cat'),
('Daisy', 2, 'Poodle', 'White', 7, 'Dog'),
('Milo', 6, 'Parakeet', 'Green', 1, 'Parrot'),
('Sadie', 2, 'Tabby', 'Orange', 4, 'Cat'),
('Bailey', 7, 'Dalmatian', 'Spotted', 11, 'Dog'),
('Oliver', 2, 'Syrian', 'Brown', 0.5, 'Hamster'),
('Chloe', 3, 'Maine Coon', 'Black', 5, 'Cat'),
('Rocky', 4, 'Red-eared Slider', 'Green', 3, 'Turtle'),
('Molly', 2, 'Beagle', 'Brown', 6, 'Dog'),
('Jack', 1, 'Abyssinian', 'Brown', 1, 'Guinea Pig'),
('Sophie', 5, 'Ragdoll', 'Calico', 7, 'Cat'),
('Toby', 8, 'Boxer', 'Brown', 15, 'Dog'),
('Coco', 2, 'Sable', 'White', 2, 'Ferret'),
('Leo', 3, 'American Shorthair', 'Orange', 4, 'Cat'),
('Bella', 4, 'Python', 'Brown', 2, 'Snake');

SELECT * FROM Pets;

SELECT *
FROM Pets
WHERE type = 'Cat';

SELECT *
FROM Pets
WHERE type = 'Cat'
AND color = 'Orange';

UPDATE Pets
SET weight = 5
WHERE id = 9;

DELETE FROM Pets
WHERE id = 3;

SELECT *
FROM Pets
WHERE age > 5;

SELECT *
FROM Pets
ORDER BY weight ASC;

SELECT *
FROM Pets
ORDER BY weight DESC
LIMIT 3;

SELECT type, COUNT(*) AS Amount
FROM Pets
GROUP BY type;

SELECT *
FROM Pets
WHERE species = 'Labrador'
AND weight IN (SELECT MIN(weight) FROM Pets WHERE species = 'Labrador');