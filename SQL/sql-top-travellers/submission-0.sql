select u.name,COALESCE(Sum(r.distance),0) as travelled_distance
from users u 
    left Join rides r 
    on u.id = r.user_id
group by u.id
order by travelled_distance desc,u.name
