-- Write your query below

select c.name from customers c 
left Join orders o On c.id = o.customer_id
where o.customer_id is null