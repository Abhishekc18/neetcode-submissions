-- Write your query below
select distinct
l.page_id as recommended_page
from (
    select user1_id as friend_id from friendship where user2_id = 1
    union
    select user2_id as friend_id from friendship where user1_id = 1
) f
join likes l on f.friend_id = l.user_id
where l.page_id not in (select page_id from likes where user_id = 1)