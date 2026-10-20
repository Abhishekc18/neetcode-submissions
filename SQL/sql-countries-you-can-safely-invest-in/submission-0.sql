SELECT c.name AS country
FROM country c
JOIN person p ON c.country_code = SUBSTRING(p.phone_number, 1, 3)
JOIN (
    SELECT caller_id AS user_id, duration FROM calls
    UNION ALL
    SELECT callee_id AS user_id, duration FROM calls
) all_calls ON p.id = all_calls.user_id
GROUP BY c.name
HAVING AVG(duration) > (SELECT AVG(duration) FROM calls)