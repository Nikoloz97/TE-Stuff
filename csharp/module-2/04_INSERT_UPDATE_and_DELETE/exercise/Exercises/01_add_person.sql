-- 1. Add a new person to the person table with the name "Lisa Byway" with the birthday of 4/15/1984 (1 row)

select * from person

insert into person (person_name, birthday)
values ('Lisa Byway', '4/15/1984');

select * from person where person_name = 'Lisa Byway'

