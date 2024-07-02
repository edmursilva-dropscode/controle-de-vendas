-- PROCEDURE: public.sp_cdv_d_cliente(integer)

-- DROP PROCEDURE IF EXISTS public.sp_cdv_d_cliente(integer);

CREATE OR REPLACE PROCEDURE public.sp_cdv_d_cliente(
	IN p_idcliente integer)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN
    DELETE FROM cliente WHERE id = p_idcliente;
    COMMIT;
END;
$BODY$;
ALTER PROCEDURE public.sp_cdv_d_cliente(integer)
    OWNER TO postgres;
