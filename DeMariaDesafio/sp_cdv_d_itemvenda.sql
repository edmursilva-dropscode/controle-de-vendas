-- PROCEDURE: public.sp_cdv_d_itemvenda(integer)

-- DROP PROCEDURE IF EXISTS public.sp_cdv_d_itemvenda(integer);

CREATE OR REPLACE PROCEDURE public.sp_cdv_d_itemvenda(
	IN p_id_item_venda integer)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN
    DELETE FROM item_venda
    WHERE id = p_id_item_venda;
END;
$BODY$;
ALTER PROCEDURE public.sp_cdv_d_itemvenda(integer)
    OWNER TO postgres;
