-- 14. The names of actors who've appeared in the movies in the "Back to the Future Collection", sorted alphabetically.
-- (28 rows)

--select * from movie
--select * from genre
--select * from movie_genre
--select * from person

select distinct person_name from movie
join movie_actor on movie_actor.movie_id = movie.movie_id
join person on movie_actor.actor_id = person.person_id
join collection on movie.collection_id = collection.collection_id
where collection.collection_name = 'Back to the Future Collection'
order by person.person_name