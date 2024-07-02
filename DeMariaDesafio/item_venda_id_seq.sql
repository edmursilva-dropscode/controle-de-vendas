-- SEQUENCE: public.item_venda_id_seq

-- DROP SEQUENCE IF EXISTS public.item_venda_id_seq;

CREATE SEQUENCE IF NOT EXISTS public.item_venda_id_seq
    INCREMENT 1
    START 1
    MINVALUE 1
    MAXVALUE 2147483647
    CACHE 1;

ALTER SEQUENCE public.item_venda_id_seq
    OWNED BY public.item_venda.id;

ALTER SEQUENCE public.item_venda_id_seq
    OWNER TO postgres;