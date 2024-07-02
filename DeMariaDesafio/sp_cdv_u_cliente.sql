-- PROCEDURE: public.sp_cdv_u_cliente(integer, character varying, character varying, character varying, timestamp without time zone, character varying, boolean)

-- DROP PROCEDURE IF EXISTS public.sp_cdv_u_cliente(integer, character varying, character varying, character varying, timestamp without time zone, character varying, boolean);

CREATE OR REPLACE PROCEDURE public.sp_cdv_u_cliente(
	IN p_idcliente integer,
	IN p_nome character varying,
	IN p_endereco character varying,
	IN p_telefone character varying,
	IN p_datacadastro timestamp without time zone,
	IN p_email character varying,
	IN p_ativo boolean)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN
    UPDATE cliente
    SET nome = p_nome,
        endereco = p_endereco,
        telefone = p_telefone,
        data_cadastro = p_datacadastro,
        email = p_email,
        ativo = p_ativo
    WHERE id = p_idcliente;
    
    COMMIT;
END;
$BODY$;
ALTER PROCEDURE public.sp_cdv_u_cliente(integer, character varying, character varying, character varying, timestamp without time zone, character varying, boolean)
    OWNER TO postgres;
