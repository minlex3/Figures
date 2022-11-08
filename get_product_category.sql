SELECT T1."PRODUCT_NAME", T3."CATEGORY_NAME"
FROM products T1
LEFT JOIN product_links T2 on T2.product = T1.product_id
LEFT JOIN categories T3 on T2.category = T3.category_id