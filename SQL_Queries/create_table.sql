--create database Project

create table account
(
	userid int primary key not null identity(1,1),
	username varchar(20),
	email varchar(30),
	password varchar(30)
)

create table member
(
	userid int primary key not null identity(1,1),
	username varchar(20),
	firstname varchar(20),
	lastname varchar(20),
	phone varchar(20),
	gender varchar(10)
)


create table admin
(
	userid int primary key not null identity(1,1),
	username varchar(20),
	firstname varchar(20),
	lastname varchar(20),
	phone varchar(20),
	gender varchar(10)
)

create table gym_owner
(
	userid int primary key not null identity(1,1),
	username varchar(20),
	firstname varchar(20),
	lastname varchar(20),
	phone varchar(20),
	gender varchar(10),
)

create table Gym
(
	gymid int primary key not null identity(1,1),
	name varchar(20),
	address varchar(50),
	membership_price int,
	owner_id int foreign key references gym_owner(userid)
)

create table trainer
(
	userid int primary key not null identity(1,1),
	username varchar(20),
	firstname varchar(20),
	lastname varchar(20),
	phone varchar(20),
	gender varchar(10),
	gym_id int foreign key references Gym(gymid),
	specialization varchar(20)
)

create table feedback
(
	feedback_id int primary key not null identity(1,1),
	fdate date,
	details varchar(100),
	member_id int foreign key references member(userid),
	trainer_id int foreign key references trainer(userid)
)

create table appointment
(
	appointment_id int primary key not null identity(1,1),
	appointment_date date,
	member_id int foreign key references member(userid),
	trainer_id int foreign key references trainer(userid)	
)

create table membership
(
	membership_id int primary key not null identity(1,1),
	duration varchar(20),
	member_id int foreign key references member(userid),
	gym_id int foreign key references gym(gymid)
)

create table diet_plan
(
 	plan_id int primary key not null identity(1,1),
	plan_name varchar(20),
	details varchar(100)
)

create table workout_plan
(
	plan_id int primary key not null identity(1,1),
	plan_name varchar(20),
	details varchar(100)	
)

create table meals
(
	meal_id int primary key not null identity(1,1),
	plan_id int foreign key references diet_plan(plan_id),
	name varchar(20),
	proteins decimal(10,2),
	fats decimal(10,2),
	fibre decimal(10,2),
	fat decimal(10,2)
)

create table exercise
(
	meal_id int primary key not null identity(1,1),
	plan_id int foreign key references workout_plan(plan_id),
	details varchar(50),
	name varchar(20),
	e_sets int,
	rest_interval int,
	target_muscle varchar(20),
	reps int
)

create table gym_review
(
	review_id int primary key identity(1,1),
	gym_id int foreign key references Gym(gymid),
	member_id int foreign key references member(userid),
	rating int,
	details varchar(100)
)

create table gym_owner_request
(
	member_id int foreign key references member(userid),
	name varchar(20),
	address varchar(50),
	membership_price int

)

create table trainer_request
(
	member_id int foreign key references member(userid),
	specialization varchar(20),
	gym_id int foreign key references  Gym(gymid)
)

create table member_diet
(
	member_id int foreign key references member(userid),
	diet_plan_id int foreign key references diet_plan(plan_id)
)

create table member_workout
(
	member_id int foreign key references member(userid),
	workout_plan int foreign key references workout_plan(plan_id)
)