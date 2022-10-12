-- 12. The titles of the movies in the "Star Wars Collection" that weren't directed by George Lucas, sorted alphabetically.
-- (5 rows)


--select * from movie
--select * from genre
--select * from movie_genre
--select * from person

select distinct title from movie
join movie_actor on movie_actor.movie_id = movie.movie_id
join person on movie.director_id = person.person_id
join collection on movie.collection_id = collection.collection_id
where collection.collection_name = 'Star Wars Collection' AND person.person_name != 'George Lucas'
order by movie.title