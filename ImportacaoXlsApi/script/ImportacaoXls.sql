PGDMP     !                     y            postgres    10.12    10.12     �
           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                       false            �
           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                       false            �
           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                       false            �
           1262    12938    postgres    DATABASE     �   CREATE DATABASE postgres WITH TEMPLATE = template0 ENCODING = 'UTF8' LC_COLLATE = 'Portuguese_Brazil.1252' LC_CTYPE = 'Portuguese_Brazil.1252';
    DROP DATABASE postgres;
             postgres    false            �
           0    0    DATABASE postgres    COMMENT     N   COMMENT ON DATABASE postgres IS 'default administrative connection database';
                  postgres    false    2799                        2615    2200    public    SCHEMA        CREATE SCHEMA public;
    DROP SCHEMA public;
             postgres    false            �
           0    0    SCHEMA public    COMMENT     6   COMMENT ON SCHEMA public IS 'standard public schema';
                  postgres    false    4                        3079    12924    plpgsql 	   EXTENSION     ?   CREATE EXTENSION IF NOT EXISTS plpgsql WITH SCHEMA pg_catalog;
    DROP EXTENSION plpgsql;
                  false            �
           0    0    EXTENSION plpgsql    COMMENT     @   COMMENT ON EXTENSION plpgsql IS 'PL/pgSQL procedural language';
                       false    2                        3079    16384 	   adminpack 	   EXTENSION     A   CREATE EXTENSION IF NOT EXISTS adminpack WITH SCHEMA pg_catalog;
    DROP EXTENSION adminpack;
                  false            �
           0    0    EXTENSION adminpack    COMMENT     M   COMMENT ON EXTENSION adminpack IS 'administrative functions for PostgreSQL';
                       false    1            �           1247    16393    chave    DOMAIN     '   CREATE DOMAIN public.chave AS integer;
    DROP DOMAIN public.chave;
       public       postgres    false    4            �            1259    16394 
   Importacao    TABLE     �   CREATE TABLE public."Importacao" (
    id public.chave NOT NULL,
    data_entrega date,
    descricao character varying(50),
    quantidade integer,
    valor_unitario numeric(15,2)
);
     DROP TABLE public."Importacao";
       public         postgres    false    4    506            �
          0    16394 
   Importacao 
   TABLE DATA               _   COPY public."Importacao" (id, data_entrega, descricao, quantidade, valor_unitario) FROM stdin;
    public       postgres    false    197   �       o
           2606    16398    Importacao Importacao_pkey 
   CONSTRAINT     \   ALTER TABLE ONLY public."Importacao"
    ADD CONSTRAINT "Importacao_pkey" PRIMARY KEY (id);
 H   ALTER TABLE ONLY public."Importacao" DROP CONSTRAINT "Importacao_pkey";
       public         postgres    false    197            �
      x������ � �     