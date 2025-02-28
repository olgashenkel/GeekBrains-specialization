USE seminar_5;

/*
****************************************************************
1.	Ззадание 1.1:
Создайте представление, в которое попадут 
автомобили стоимостью до 25 000 долларов.
****************************************************************
*/

-- Создание и наполнение данными таблицы cars 
DROP TABLE IF EXISTS cars;
CREATE TABLE cars
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(20),
	cost INT
);

INSERT INTO cars(name, cost)
VALUES
('Audi', 52642),
('Mercedes', 57127),
('Skoda', 9000),
('Volvo', 29000),
('Bentley', 350000),
('Citroen', 21000),
('Hummer', 41400),
('Volksvagen', 21600);

-- Создание представления
CREATE OR REPLACE VIEW view_cars AS
	SELECT *
    FROM cars
    WHERE cost < 25000
	ORDER BY cost DESC;

-- Запрос созданного представления
SELECT * FROM view_cars;


/*
****************************************************************
2.	Ззадание 1.2:
Изменить в существующем представлении порог стоимости: 
пусть цена будет до 30000 долларов (используя оператор ALTER VIEW).
****************************************************************
*/

-- Изменение представления
ALTER VIEW view_cars AS
	SELECT * FROM cars
    WHERE cost < 30000
ORDER BY cost DESC;

-- Запрос представления
SELECT * FROM view_cars;


/*
****************************************************************
2.	Ззадание 1.3:
Изменить в существующем представлении порог стоимости: 
пусть цена будет до 30000 долларов (используя оператор ALTER VIEW).
****************************************************************
*/

-- Создание представления
CREATE VIEW view_2_cars AS
	SELECT * FROM cars
    WHERE name IN ('Audi', 'Skoda');

-- Запрос представления
SELECT * FROM view_2_cars;


