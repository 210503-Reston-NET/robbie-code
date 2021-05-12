-- Add 5 associates to the associate table 
insert into associates (associateName, associateLocale, revaPoints) values
('Eva', 'MD', 100),('Venkata', 'ca', 100),('Mykel', 'WA', 75),('John', 'TX', 30),('Jean', 'FL', 50);

-- Get all associates that live in a certain state 
SELECT * FROM associates WHERE associateLocale = 'WA';
-- Get the number of associates living in the various states
SELECT associateLocale, COUNT(associateLocale) FROM associates GROUP BY associateLocale
	ORDER BY count(associateLocale) ASC-- Give the number in descending and ascending order
SELECT associateLocale, COUNT(associateLocale) FROM associates GROUP BY associateLocale
	ORDER BY count(associateLocale) DESC

-- Use Joins, Set Operations, and Subqueries to: 
	-- Get all trainers without associates 
SELECT * FROM trainers RIGHT JOIN batch ON batch.trainerID = trainers.id;

	-- Get all the associates mapped to a trainer 
SELECT * FROM associates WHERE id IN (SELECT trainerID FROM batch);

	-- Get all associates without a trainer
SELECT * FROM associates WHERE id NOT IN (SELECT trainerID FROM batch);

select a.id, a.associateName from associates a inner join batch b on b.associateID  = a.id;
