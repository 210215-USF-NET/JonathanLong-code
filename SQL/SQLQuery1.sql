  
--for sql server--
drop table batch;
drop table trainers;
drop table associates;
create table associates
(
	id int identity primary key,
	associateName nvarchar(100) not null,
	associateLocale varchar(2) not null,
	revaPoints int not null
);
create table trainers
(
	id int identity primary key,
	trainerName varchar(20) not null,
	campus varchar(3) not null,
	caffeineLevel int not null
);
create table batch
(
	id int identity primary key,
	associateID int references associates(id),
	trainerID int references trainers (id)
);

insert into associates (associateName, associateLocale, revaPoints) values 
('Joaquin', 'PA', -10), ('Madeline', 'WA', 10), ('Jacob', 'FL', 0), ('Michael', 'AZ', 20), ('Janel', 'AZ', 50), ('Angeleen', 'TX', 30), ('Warren', 'NH', 40);
insert into trainers (trainerName, campus, caffeineLevel) values
('Marielle', 'USF', 5), ('Pushpinder', 'UTA', 50), ('Nick', 'UTA', 75), ('Mark', 'WVU', 16), ('Fred', 'UTA', 25);
insert into batch (associateID, trainerID) values
(3,3), (1,1), (2,1), (4,1), (6,1), (7,1);

--Q1--
insert into associates (associateName, associateLocale, revaPoints) values
('Jack', 'MA', 20), ('Zachary', 'VA', 50), ('Sam', 'MA', 0), ('Max', 'TN', 35), ('Tanner', 'MA', 70);

--Q2--
Select associateName from associates Where associateLocale = 'MA';

--Q3--
select count(id) as [Number of Associates], associateLocale as [State] from associates group by associateLocale;

--Q4(a)--
select trainerName from trainers where ID Not In (select trainerID from trainers right join batch on trainers.id = batch.trainerID);

--Q4(b)--
select associateName, trainerName from associates right join batch on associates.id = batch.associateID left join trainers on trainers.id = batch.trainerID;

--Q4(c)--
select associateName as [Associates Without Trainers] from associates where associates.id Not in(select associates.id from associates right join batch on associates.id = batch.associateID);