-- 11. Hollywood is remaking the classic movie "The Blob" and doesn't have a director yet. Add yourself to the person table, and assign yourself as the director of "The Blob" (the movie is already in the movie table). (1 record each)


--select * from person
--select * from movie
--select person_id from person where person_name = 'Nick Gotsy'
--select movie_id from movie where title = 'The Blob'
--person_id = 3984917

insert into person (person_name)
values ('Nick Gotsy')

update movie set director_id = (select person_id from person where person_name = 'Nick Gotsy') where title = 'The Blob'