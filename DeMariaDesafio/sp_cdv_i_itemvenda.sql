-- PROCEDURE: public.sp_cdv_i_itemvenda(integer, integer, integer, numeric, numeric)

-- DROP PROCEDURE IF EXISTS public.sp_cdv_i_itemvenda(integer, integer, integer, numeric, numeric);

CREATE OR REPLACE PROCEDURE public.sp_cdv_i_itemvenda(
	IN p_id_venda integer,
	IN p_id_produto integer,
	IN p_quantidade integer,
	IN p_preco_unitario numeric,
	IN p_preco_total numeric)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN
    INSERT INTO item_venda (id_venda, id_produto, quantidade, preco_unitario, preco_total)
    VALUES (p_id_venda, p_id_produto, p_quantidade, p_preco_unitario, p_preco_total);
END;
$BODY$;
ALTER PROCEDURE public.sp_cdv_i_itemvenda(integer, integer, integer, numeric, numeric)
    OWNER TO postgres;
