-- Write your query below
select id, 
Case 
    when t.p_id is null then 'Root'
    when t.id in (select p_id from tree where p_id is not null) then 'Inner'
    else 'Leaf'
    end as type
from tree t
