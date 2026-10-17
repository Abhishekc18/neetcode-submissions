-- Write your query below
select 
c.customer_id, c.name 
from orders o
Join customers c on o.customer_id = c.customer_id
Join product p on o.product_id = p.product_id
group by c.customer_id, c.name
having 
Sum(case when to_char(o.order_date, 'YYYY-MM') = '2020-06' then p.price * o.quantity else 0 end) >= 100 and
Sum(case when to_char(o.order_date, 'YYYY-MM') = '2020-07' then p.price * o.quantity else 0 end) >= 100