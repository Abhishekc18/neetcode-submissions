-- Write your query below
select 
min(p2.x - p1.x) as shortest
from point p1
Join point p2 On p1.x < p2.x
