-- 17. The titles and taglines of movies that are in the "Family" genre that Samuel L. Jackson has acted in.
-- Order the results alphabetically by movie title.
-- (4 rows)

--select * from movie
--select * from genre
--select * from movie_genre
--select * from person

select distinct movie.title, movie.tagline from movie
join movie_actor on movie_actor.movie_id = movie.movie_id
join person on movie_actor.actor_id = person.person_id
join movie_genre on movie_genre.movie_id = movie.movie_id
join genre on movie_genre.genre_id = genre.genre_id
where person.person_name = 'Samuel L. Jackson' AND genre.genre_name = 'Family'
order by movie.title