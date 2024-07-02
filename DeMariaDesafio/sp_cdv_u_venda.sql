-- PROCEDURE: public.sp_cdv_u_venda(integer, integer, timestamp without time zone, numeric, integer, text)

-- DROP PROCEDURE IF EXISTS public.sp_cdv_u_venda(integer, integer, timestamp without time zone, numeric, integer, text);

CREATE OR REPLACE PROCEDURE public.sp_cdv_u_venda(
	IN p_id_venda integer,
	IN p_id_cliente integer,
	IN p_data timestamp without time zone,
	IN p_total numeric,
	IN p_id_status integer,
	IN p_observacao text)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN
    -- Atualiza a venda na tabela 'venda'
    UPDATE venda
    SET id_cliente = p_id_cliente,
        data = p_data,
        total = p_total,
        id_status = p_id_status,
        observacao = p_observacao
    WHERE id = p_id_venda;
END;
$BODY$;
ALTER PROCEDURE public.sp_cdv_u_venda(integer, integer, timestamp without time zone, numeric, integer, text)
    OWNER TO postgres;
