-- PROCEDURE: public.sp_cdv_i_cliente(character varying, character varying, character varying, character varying, timestamp without time zone, boolean)

-- DROP PROCEDURE IF EXISTS public.sp_cdv_i_cliente(character varying, character varying, character varying, character varying, timestamp without time zone, boolean);

CREATE OR REPLACE PROCEDURE public.sp_cdv_i_cliente(
	IN p_nome character varying,
	IN p_endereco character varying,
	IN p_telefone character varying,
	IN p_email character varying,
	IN p_data timestamp without time zone,
	IN p_ativo boolean)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN
    INSERT INTO cliente (nome, endereco, telefone, email, data_cadastro, ativo)
    VALUES (p_nome, p_endereco, p_telefone, p_email, p_data, p_ativo);
    
    COMMIT;
END;
$BODY$;
ALTER PROCEDURE public.sp_cdv_i_cliente(character varying, character varying, character varying, character varying, timestamp without time zone, boolean)
    OWNER TO postgres;
