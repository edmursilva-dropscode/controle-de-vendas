-- PROCEDURE: public.sp_cdv_u_produto(integer, character varying, integer, numeric, timestamp without time zone, boolean)

-- DROP PROCEDURE IF EXISTS public.sp_cdv_u_produto(integer, character varying, integer, numeric, timestamp without time zone, boolean);

CREATE OR REPLACE PROCEDURE public.sp_cdv_u_produto(
	IN p_idproduto integer,
	IN p_descricao character varying,
	IN p_quantidade integer,
	IN p_preco numeric,
	IN p_data timestamp without time zone,
	IN p_ativo boolean)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN
    UPDATE produto
    SET 
        descricao = p_descricao,
        quantidade = p_quantidade,
        preco = p_preco,
        data_cadastro = p_data,
        ativo = p_ativo
    WHERE
        id = p_idproduto;
END;
$BODY$;
ALTER PROCEDURE public.sp_cdv_u_produto(integer, character varying, integer, numeric, timestamp without time zone, boolean)
    OWNER TO postgres;
