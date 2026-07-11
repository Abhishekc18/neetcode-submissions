-- Write your query below

--select first_name,last_name,
--case when city is null then null else city end as city,
--case when state is null then null else state end as state
--from person p
--left Join address a on p.person_id = a.person_id;

SELECT
    p.first_name,
    p.last_name,
    a.city,
    a.state
FROM person p
LEFT JOIN address a
    ON p.person_id = a.person_id;