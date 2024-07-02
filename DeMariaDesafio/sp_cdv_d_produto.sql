-- PROCEDURE: public.sp_cdv_d_produto(integer)

-- DROP PROCEDURE IF EXISTS public.sp_cdv_d_produto(integer);

CREATE OR REPLACE PROCEDURE public.sp_cdv_d_produto(
	IN p_idproduto integer)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN
    DELETE FROM produto WHERE id = p_idproduto;
    COMMIT;
END;
$BODY$;
ALTER PROCEDURE public.sp_cdv_d_produto(integer)
    OWNER TO postgres;
