<template>
    <div style="background-color: var(--wrapper-background-color); padding: 25px; margin: 15px auto;">
        <header>
            <img :src="companyLogo" alt="céglogó">
        </header>
    
        <main>
            <p>Ha kérdésed van  e-mailben felteheted. <small>Válaszidö: 3-5 nap</small></p>
        </main>
    
        <section>
            <table>
                <tr>
                    <th>
                        <button><a href="mailto:bsze2teszpet@vasvari.org">Tesszáry Péter Kapcsolati e-mail</a></button>
                        <button><a href="mailto:bsze2perdan@vasvari.org">Pernyész Dániel Kapcsolati e-mail</a></button>
                        <button><a href="mailto:bsze2bagpet@vasvari.org">Bagi Péter Kapcsolati e-mail</a></button>
                    </th>
                </tr>
            </table>
        </section>
    </div>
    </template>
    
    <script setup>
    import companyLogo from '../images/syncbundlelogo.png';
    
    </script>
    
    <style scoped>
    /*header settings whit css grid */
    header
    {
        display: grid;
        grid-template-columns: repeat(12, 1fr);
        grid-template-rows: auto;
        padding: 10px;
        gap: 5px;
    }
    img
    {
        grid-column: 1 / 5;
        grid-row: auto;
    }
    p
    {
        font-size: 20px;
        font-weight: var(--font-weight);
        color: var(--font-color);
        letter-spacing: var(--letter-spacing);
    }
    /*table settings flexbox */
    table
    {
        display: flex;
        text-align: center;
        justify-content: center;
        gap: 25px;
        padding-top: 25px;
        
    }
    table tr
    {
        display: flex;
        gap: 20px;
    }
    table tr th 
    {
        display: flex;
        flex-direction: column;
        font-weight: var(--secondary-font-weight);
        color: var(--font-color);
    }
    section table tr th button
    {
        margin-bottom: 15px;
    }
    section table tr th button a
    {
        letter-spacing: var(--letter-spacing);
        font-size: 17px;
    }
    section table tr th button a:hover
    {
        text-decoration: underline;
        color: hsl(340, 49%, 32%);
    }
    
    </style>