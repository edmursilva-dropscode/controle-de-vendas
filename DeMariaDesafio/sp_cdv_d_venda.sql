-- PROCEDURE: public.sp_cdv_d_venda(integer)

-- DROP PROCEDURE IF EXISTS public.sp_cdv_d_venda(integer);

CREATE OR REPLACE PROCEDURE public.sp_cdv_d_venda(
	IN p_id_venda integer)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN
    -- Inicia uma transação
    BEGIN
        -- Exclui os itens relacionados à venda
        DELETE FROM item_venda
        WHERE id_venda = p_id_venda;

        -- Exclui a venda
        DELETE FROM venda
        WHERE id = p_id_venda;
    EXCEPTION
        -- Captura qualquer exceção que ocorrer durante a exclusão
        WHEN OTHERS THEN
            -- Rollback da transação em caso de erro
            ROLLBACK;
            -- Lança uma mensagem de erro personalizada
            RAISE EXCEPTION 'Erro ao excluir venda e seus itens: %', SQLERRM;
    END;
END;
$BODY$;
ALTER PROCEDURE public.sp_cdv_d_venda(integer)
    OWNER TO postgres;
