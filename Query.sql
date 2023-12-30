
CREATE DATABASE restro;

USE restro;

CREATE TABLE items (
    iid INT IDENTITY(1,1) PRIMARY KEY,
    name VARCHAR(250) NOT NULL,
    category VARCHAR(250) NOT NULL,
    price BIGINT NOT NULL
);

-- Insert sample data (optional)
INSERT INTO items (name, category, price)
VALUES ('Item1', 'Category1', 10),
       ('Item2', 'Category2', 20),
       ('Item3', 'Category1', 15);

-- Select data from the items table
SELECT * FROM items;
