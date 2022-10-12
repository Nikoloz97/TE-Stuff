-- 11. The titles of the movies in the "Star Wars Collection" ordered by release date, most recent first. 
-- (9 rows)


--select * from movie
--select * from genre
--select * from movie_genre
--select * from collection

select title from movie
join collection on movie.collection_id = collection.collection_id
where collection_name = 'Star Wars Collection'
order by movie.release_date desc