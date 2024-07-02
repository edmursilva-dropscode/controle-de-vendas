-- PROCEDURE: public.sp_cdv_i_produto(character varying, integer, numeric, timestamp without time zone, boolean)

-- DROP PROCEDURE IF EXISTS public.sp_cdv_i_produto(character varying, integer, numeric, timestamp without time zone, boolean);

CREATE OR REPLACE PROCEDURE public.sp_cdv_i_produto(
	IN p_descricao character varying,
	IN p_quantidade integer,
	IN p_preco numeric,
	IN p_data timestamp without time zone,
	IN p_ativo boolean)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN
    INSERT INTO produto (descricao, quantidade, preco, data_cadastro, ativo)
    VALUES (p_descricao, p_quantidade, p_preco, p_data, p_ativo);
END;
$BODY$;
ALTER PROCEDURE public.sp_cdv_i_produto(character varying, integer, numeric, timestamp without time zone, boolean)
    OWNER TO postgres;
