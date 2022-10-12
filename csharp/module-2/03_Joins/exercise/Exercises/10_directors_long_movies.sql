-- 10. The names of directors who have directed a movie over 3 hours [180 minutes], sorted alphabetically.
-- (15 rows)


--select * from movie
--select * from genre
--select * from movie_genre
--select * from person

select distinct person_name from movie
join movie_actor on movie_actor.movie_id = movie.movie_id
join person on movie.director_id = person.person_id
where movie.length_minutes > 180
order by person_name