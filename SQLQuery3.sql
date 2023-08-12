
CREATE TABLE real_estate ( 
	id INT PRIMARY KEY, 
	address VARCHAR(255), 
	cadastral_number VARCHAR(20), 
	area FLOAT, 
	year_of_construction INT, 
	responsible_person VARCHAR(255), 
	materials VARCHAR(255), 
); 

CREATE TABLE building_floors ( 
	id INT PRIMARY KEY, 
	estate_id INT, 
	floor_number INT, 
	FOREIGN KEY (estate_id) REFERENCES real_estate (id),
);

CREATE TABLE users (
	id INT Primary KEY,
	username VARCHAR (30),
	pasword VARCHAR (20),
);
