USE master;
GO

Drop database if exists ArtGallery;

Create Database ArtGallery;
GO

Use ArtGallery;
GO

Begin Transaction;

create table customer (
customer_id int identity(1,1)
customer_name varchar(50)
);

