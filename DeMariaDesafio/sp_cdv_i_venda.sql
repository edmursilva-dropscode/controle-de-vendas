-- PROCEDURE: public.sp_cdv_i_venda(integer, timestamp without time zone, numeric, integer, text)

-- DROP PROCEDURE IF EXISTS public.sp_cdv_i_venda(integer, timestamp without time zone, numeric, integer, text);

CREATE OR REPLACE PROCEDURE public.sp_cdv_i_venda(
	IN p_id_cliente integer,
	IN p_data timestamp without time zone,
	IN p_total numeric,
	IN p_id_status integer,
	IN p_observacao text,
	OUT p_id_venda integer)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN
    INSERT INTO venda (id_cliente, data, total, id_status, observacao)
    VALUES (p_id_cliente, p_data, p_total, p_id_status, p_observacao)
    RETURNING id INTO p_id_venda;  -- Captura o ID da venda inserida e atribui a p_id_venda
END;
$BODY$;
ALTER PROCEDURE public.sp_cdv_i_venda(integer, timestamp without time zone, numeric, integer, text)
    OWNER TO postgres;
