-- PROCEDURE: public.sp_cdv_u_itemvenda(integer, integer, integer, integer, numeric, numeric)

-- DROP PROCEDURE IF EXISTS public.sp_cdv_u_itemvenda(integer, integer, integer, integer, numeric, numeric);

CREATE OR REPLACE PROCEDURE public.sp_cdv_u_itemvenda(
	IN p_id_item_venda integer,
	IN p_id_venda integer,
	IN p_id_produto integer,
	IN p_quantidade integer,
	IN p_preco_unitario numeric,
	IN p_preco_total numeric)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN
    UPDATE item_venda
    SET
        id_venda = p_id_venda,
        id_produto = p_id_produto,
        quantidade = p_quantidade,
        preco_unitario = p_preco_unitario,
        preco_total = p_preco_total
    WHERE
        id = p_id_item_venda;
END;
$BODY$;
ALTER PROCEDURE public.sp_cdv_u_itemvenda(integer, integer, integer, integer, numeric, numeric)
    OWNER TO postgres;
