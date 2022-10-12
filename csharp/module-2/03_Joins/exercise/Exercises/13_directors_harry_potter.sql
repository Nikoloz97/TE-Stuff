-- 13. The directors of the movies in the "Harry Potter Collection", sorted alphabetically.
-- (4 rows)


--select * from movie
--select * from genre
--select * from movie_genre
--select * from person

select distinct person_name from movie
join movie_actor on movie_actor.movie_id = movie.movie_id
join person on movie.director_id = person.person_id
join collection on movie.collection_id = collection.collection_id
where collection.collection_name = 'Harry Potter Collection'
order by person.person_name