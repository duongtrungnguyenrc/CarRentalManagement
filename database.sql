create database CarRental

CREATE TABLE Customer
(
  customer_id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
  name varchar(255) NOT NULL,
  phone varchar(10) NOT NULL,
  address varchar(255) NOT NULL,
  gender varchar(255) NOT NULL,
  identifier varchar(20) NOT NULL
);


CREATE TABLE Car_general
(
  general_id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
  car_type varchar(255) NOT NULL,
  number_of_seats INT NOT NULL,
  engine_type varchar(255) NOT NULL,
);

CREATE TABLE Salary
(
  id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
  basic_salary float NOT NULL,
  update_time date NOT NULL,
);

CREATE TABLE SystemUser
(
  user_id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
  name varchar(255) NOT NULL,
  gender varchar(6) NOT NULL,
  birth date NOT NULL,
  address varchar(255) NOT NULL,
  identifier varchar(20) NOT NULL,
  shift varchar(255) NOT NULL,
  coefficients_salary float NOT NULL,
);

CREATE TABLE SystemAccount
(
  account_id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
  user_name varchar(255) NOT NULL,
  password varchar(255) NOT NULL,
  role varchar(5) NOT NULL,
  user_id UNIQUEIDENTIFIER,
  FOREIGN KEY (user_id) REFERENCES SystemUser(user_id)
);

CREATE TABLE PostContract
(
  post_contract_id UNIQUEIDENTIFIER NOT NULL,
  account_id UNIQUEIDENTIFIER NOT NULL,
  contract_id UNIQUEIDENTIFIER,
  status varchar(255) NOT NULL,
  note varchar(255) NOT NULL,
  extra_charge float NOT NULL,
  PRIMARY KEY (post_contract_id),
  FOREIGN KEY (account_id) REFERENCES SystemAccount(account_id),
  foreign key (contract_id) references PreContract(contract_id),
);

CREATE TABLE PreContract
(
  contract_id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
  rental_start_date date NOT NULL,
  rental_end_date date NOT NULL,
  contract_date date NOT NULL,
  total_prices float NOT NULL,
  payment_method varchar(255) NOT NULL,
  status varchar(255) NOT NULL,
  customer_id UNIQUEIDENTIFIER NOT NULL,
  account_id UNIQUEIDENTIFIER NOT NULL,
  FOREIGN KEY (customer_id) REFERENCES Customer(customer_id),
  FOREIGN KEY (account_id) REFERENCES SystemAccount(account_id),
);

CREATE TABLE Car
(
  car_id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
  car_img varchar(255) NOT NULL,
  car_name INT NOT NULL,
  rent_by_time INT NOT NULL,
  rent_by_date INT NOT NULL,
  car_year INT NOT NULL,
  car_price INT NOT NULL,
  number_of_km INT NOT NULL,
  deposit_price INT NOT NULL,
  type_id UNIQUEIDENTIFIER NOT NULL,
  FOREIGN KEY (type_id) REFERENCES CarType(type_id)
);

drop table Car

CREATE TABLE contract_detail
(
  detail_id INT NOT NULL,
  contract_id INT NOT NULL,
  car_id INT NOT NULL,
  PRIMARY KEY (detail_id),
  FOREIGN KEY (contract_id) REFERENCES PreContract(contract_id),
  FOREIGN KEY (car_id) REFERENCES Car(car_id)
);