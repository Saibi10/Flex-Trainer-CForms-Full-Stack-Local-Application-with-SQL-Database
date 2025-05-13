-- Inserting into account table
insert into account (username, email, password) values
('hasssaan', 'hassaan.234@gmail.com', 'i22-0890'),
('saima_k', 'saima.k@hotmail.com', '786Saima!'),
('rafiq_ali', 'rafiq.ali@gmail.com', 'aliRafiq123'),
('anwar123', 'anwar123@example.com', 'anwar786!'),
('nida_khan', 'nida.khan@yahoo.com', 'kh@nNida456'),
('tariq_007', 'tariq_007@hotmail.com', '007Tariq!'),
('zain786', 'zain786@gmail.com', 'zainK786'),
('asma123', 'asma123@example.com', 'A$ma456!'),
('umar_khan', 'umar.khan@yahoo.com', 'um@r789!'),
('nadia786', 'nadia786@hotmail.com', 'n@d1@786!'),
('sara_khan', 'sara.khan@example.com', 'khanSara789'),
('usman123', 'usman123@gmail.com', '123usman!'),
('farah_malik', 'farah.malik@hotmail.com', 'malikFarah456'),
('ahmad_ali', 'ahmad.ali@yahoo.com', 'ahmad123_ali'),
('hussnain', 'hussnain.mughal@gmail.com', 'nbwy7zain');

-- Inserting into member table
insert into member (username, firstname, lastname, phone, gender) values
('nadia786', 'nadia', 'malik', '03007486532', 'Female'),
('umar_khan', 'umar', 'khan', '03002576432', 'Male'),
('asma123', 'asma', 'tariq', '03214735672', 'Female'),
('zain786', 'zain', 'tahir', '03331975433', 'Male'),
('tariq_007', 'tariq', 'ali', '03227829432', 'Male'),
('sara_khan', 'sara', 'khan', '03017826462', 'Female'),
('usman123', 'usman', 'arshad', '03026748526', 'Male'),
('farah_malik', 'farah', 'malik', '03013526462', 'Female'),
('ahmad_ali', 'ahmad', 'ali', '03015109234', 'Male');

-- Inserting into gym_owner table
insert into gym_owner (username, firstname, lastname, phone, gender) values
('saima_k', 'saima', 'kamran', '03225322773', 'Female'),
('rafiq_ali', 'rafiq', 'ali', '03216345842', 'Male');

-- Inserting into Gym table
insert into Gym (name, address, membership_price, owner_id) values
('Max Trainer', 'F-10 Markaz Islamabad', 1000, 1),
('Get Strong', 'G-6/4 Islamabad', 750, 2);

-- Inserting into trainer table with adjusted specialization values
insert into trainer (username, firstname, lastname, phone, gender, specialization, gym_id) values
('anwar123', 'anwar', 'iqbal', '03086329343', 'Male', 'Cardiovascular', 1),
('nida_khan', 'nida', 'khan', '03013879654', 'Female', 'Group Fitness', 2);

-- Inserting into workout_plan table
insert into workout_plan (plan_name, details) values
('Lose Weight', 'Quickly Lose Weight with this easy to do routine'),
('Beginners', 'A simple start to your workout journey');

-- Inserting into exercise table
insert into exercise (plan_id, details, name, e_sets, rest_interval, target_muscle, reps) values
(2, 'Normal Pushups', 'Pushups', 5, 10, 'Chest', 10),
(2, 'Start with a weight that comfortable', 'Bench Press', 4, 90, 'Chest', 10),
(2, 'Start Low and slowly go up the weights', 'Deadlifts', 4, 120, 'Back', 8),
(2, 'Pull-Ups', 'Pull-Ups', 4, 90, 'Back', 8),
(2, 'Hold as long as you can', 'Plank', 3, 60, 'Core', NULL),
(1, 'Run at a comfortable speed for 5km', 'Running', 1, 0, 'Cardio', NULL),
(1, 'Jump Rope', 'Jump Rope', 3, 30, 'Cardio', NULL),
(1, 'An actual cycle or a gym one', 'Cycling', 3, 0, 'Cardio', NULL),
(1, 'Basic Burpees', 'Burpees', 3, 30, 'Full Body', NULL),
(1, 'High-Intensity Interval Training (HIIT)', 'HIIT', 3, 30, 'Cardio', NULL);

-- Inserting into member_workout table
insert into member_workout (member_id, workout_plan) values
(1, 2),
(3, 1),
(4, 1),
(6, 2),
(7, 2);

-- Inserting into diet_plan table
insert into diet_plan (plan_name, details) values
('Weight loss', 'A Simple 3 time meal prep for weightloss'),
('Bulking', 'A meal plan if you want to bulk in healthy manner');

-- Inserting into meals table with further adjusted meal names
insert into meals (plan_id, name, proteins, fats, fibre, fat) values
(1, 'Grilled Chicken', 30, 10, 5, 15),
(1, 'Quinoa and Stir-Fry', 10, 5, 8, 30),
(1, 'Salmon and Asparagus', 25, 12, 6, 10),
(2, 'Beef and Rice Bowl', 40.5, 15.2, 4.3, 50.8),
(2, 'Chicken and Sweet', 35.7, 10.4, 6.1, 40.9),
(2, 'Fried Eggs', 30.9, 12.6, 5.2, 40.3);

-- Inserting into member_diet table
insert into member_diet (member_id, diet_plan_id) values
(5, 1),
(3, 1),
(2, 2),
(6, 1),
(7, 2);

-- Inserting into admin table
insert into admin (username, firstname, lastname, phone, gender) values
('hasssaan', 'hassaan', 'anwar', '03002326776', 'Male'),
('hussnain', 'Hussnain', 'Mughal', '03015556405', 'Male'),
('saibi', 'Sohaib', 'Aslam', '03015202466', 'Male');

-- Inserting into membership table
insert into membership (duration, member_id, gym_id) values
('2 Months', 1, 1),
('3 Months', 1, 2),
('1 Month', 2, 2),
('6 Months', 2, 1),
('4 Months', 1, 2);

-- Inserting into trainer_request table
insert into trainer_request (member_id, specialization, gym_id) values
(6, 'Calisthenics', 2),
(9, 'Weight Lifting', 1);

-- Inserting into gym_owner_request table
insert into gym_owner_request (member_id, name, address, membership_price) values
(8, 'Gym Better', 'H-11 Markaz', 550),
(7, 'The Gym', 'F-8/2 Islamabad', 500),
(4, 'Muscle', 'Saddar', 1200);
