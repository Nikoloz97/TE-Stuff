use master;
GO

drop database if exists Meetups;
GO

create Database Meetups;
GO

USE Meetups;
GO

Begin transaction;

create table Member (
Member_id int identity (1,1),
Last_name varchar(128) Not null ,
First_name varchar(128) Not null,
Email_address varchar(128) Not null,
Phone_number varchar(128),
Date_of_birth datetime Not null,
Reminder_emails bit 

constraint pk_member primary key (Member_id)
);

create table MeetGroup (
Group_id int identity (1,1),
Group_name varchar(128) unique Not null,

constraint pk_group primary key (Group_id)
);

create table Member_Group (
Member_id int ,
Group_id int

constraint fk_Member_1 foreign key (Member_id) references Member(Member_id),
constraint fk_Event_1 foreign key (Group_id) references MeetGroup(Group_id)
);

create table MeetEvent (
Event_id int identity (1,1),
Event_Name varchar(128) Not null, 
Event_desc varchar(128) Not null,
Date_time datetime Not null,
Duration_min int check (Duration_min >= 30) Not null,
Group_id int

constraint pk_event primary key (Event_id)
constraint fk_group foreign key (Group_id) references MeetGroup(Group_id)
);


create table Member_Event (

Member_id int,
Event_id int

constraint fk_Member_2 foreign key (Member_id) references Member(Member_id),
constraint fk_Event_2 foreign key (Event_id) references MeetEvent(Event_id)
);





commit;


-- Members (8)
insert into Member (Last_name, First_name, Email_address, Phone_number, Date_of_birth, Reminder_emails)
values ('Smith', 'Bob', 'Bobsmith@yahoo.com', '5555555555', '10/15/1998', 1), 
('Shmoe', 'Joe', 'JoeShmoe@yahoo.com', '5555555554', '10/14/1998', 1),
('Sims', 'Erica', 'ES@yahoo.com', '5555555553', '10/12/1998', 0),
('Fall', 'Taco', 'TF@yahoo.com', '5555555552', '10/05/1998', 1),
('Pots', 'Jacob', 'JP@yahoo.com', '5555555551', '10/20/1998', 0),
('Wiggins', 'Andrew', 'AWiggins@yahoo.com', '5555555550', '10/15/2005', 1),
('Harris', 'Tobias', 'TobiasHarris@yahoo.com', '5555555559', '01/15/1998', 1),
('Irving', 'Kyrie', 'KyrieIrving@yahoo.com', '5555555558', '02/15/2012', 0); 

-- Groups (3)
insert into MeetGroup(Group_name)
values ('Group1'),
('Group2'),
('Group3');


-- Events (4)
insert into MeetEvent (Event_Name, Event_desc, Duration_min, Date_time, Group_id)
values ('Party Rocking', 'There is a lot of partying going on', 55, '2022-10-18 10:15:00', (select Group_id from MeetGroup where Group_name = 'Group1')),
 ('In the House Tonight', 'There is also lot of partying going on', 100, '2022-10-18 10:45:00', (select Group_id from MeetGroup where Group_name = 'Group2')),
 ('Everybody Just Wants', 'There is a lot of partying going on', 300, '2022-10-18 11:30:00', (select Group_id from MeetGroup where Group_name = 'Group1')),
 ('To Have a Good Time', 'There is even more partying going on', 55, '2022-10-18 12:30:00', (select Group_id from MeetGroup where Group_name = 'Group3'));


 -- Assign each group to at least 2 members
 insert into Member_Group (Member_id, Group_id)
 values ((select Member_id from Member where Email_address = 'Bobsmith@yahoo.com'), (select Group_id from MeetGroup where Group_name = 'Group1')),
 ((select Member_id from Member where Email_address = 'JoeShmoe@yahoo.com'), (select Group_id from MeetGroup where Group_name = 'Group1')),
  ((select Member_id from Member where Email_address = 'ES@yahoo.com'), (select Group_id from MeetGroup where Group_name = 'Group2')),
 ((select Member_id from Member where Email_address = 'TF@yahoo.com'), (select Group_id from MeetGroup where Group_name = 'Group2')),
  ((select Member_id from Member where Email_address = 'JP@yahoo.com'), (select Group_id from MeetGroup where Group_name = 'Group3')),
   ((select Member_id from Member where Email_address = 'AWiggins@yahoo.com'), (select Group_id from MeetGroup where Group_name = 'Group3'));

 -- Assign each event to at least one member
  insert into Member_Event(Member_id, Event_id)
  values ((select Member_id from Member where Email_address = 'Bobsmith@yahoo.com'), (select Event_id from MeetEvent where Event_name = 'Party Rocking')),
 ((select Member_id from Member where Email_address = 'JoeShmoe@yahoo.com'), (select Event_id from MeetEvent where Event_name = 'Party Rocking')),
  ((select Member_id from Member where Email_address = 'ES@yahoo.com'), (select Event_id from MeetEvent where Event_name = 'In the House Tonight')),
 ((select Member_id from Member where Email_address = 'TF@yahoo.com'), (select Event_id from MeetEvent where Event_name = 'Everybody Just Wants')),
  ((select Member_id from Member where Email_address = 'JP@yahoo.com'), (select Event_id from MeetEvent where Event_name = 'To Have a Good Time')),
   ((select Member_id from Member where Email_address = 'AWiggins@yahoo.com'), (select Event_id from MeetEvent where Event_name = 'To Have a Good Time'));
