<template>
    <!--web and dekstop app default informations-->
        <main>
            <div class="wrapper">
                <span><h1>eCommerceSyncBundle</h1></span>
                <div class="tech">WordPress alapú online kereskedelmi platform.</div>
                <div class="description">
                    A WordPress egy nyílt forráskódú tartalomkezelő rendszer amely mára rendkivül elterjedt. 
                    <small>2023-ban a weboldalak 43,2% ezt használja.</small>
                </div>
                <div class="whoocommerce">
                    A WordPress weboldalunkat a WhooCommerce bővítmény segítségével webárúház tulajdonságokkal tudjuk felruházni.
                </div>
                <!--add animation-->
                <div class="action">
                    Miért jött létre? <button @click="showSection()"><i :class="[show ? 'bi bi-x p-2' : 'bi bi-journal-arrow-down p-2']"></i></button>
                </div>
               <Transition name="fade">
                <div class="section" v-show="show">Sok vállalkozást magánszemély működtet melyek online kerekskedelemmel
                foglalkoznak. Ezek a személyek gyakran semmi előképzetséggel nem rendelkeznek a webprogramozás területén.
                Számukra szerettünk volna segítséget nyújtani evvel az egyedi és egyszerűen kezelhető csomaggal.</div>
               </Transition>
            </div>
        </main>
        <!--dekstop app desciptions-->
         <section>
            <div class="wrapper-dekstop-application">
                <h2>Asztali alkalmazás</h2>
                <div class="description-dekstop-application">
                    A Desktop applikáció egy Java alapú szoftver, melynek kezelőfelületét Java Fx-el
                    terveztük. Az asztali
                    applikáció egy egyszerű kezelőfelülettel rendelkezik. Itt a felhasználó a termékeket tudja
                    felvinni, illetve módosítani. A belépéshez szükséges felhasználói adatokat elsőként a WordPress
                    adminisztrációs felületén kell létrehozni. A következő szinkronizációt követően (weboldal és
                    asztali alkalmazás) már ugyan ez a felhasználó képes lesz belépni az asztali alkalmazásba is.
                </div>
                    <div class="mariadbimage">
                        <img :src="rotateImageDatabase" alt="MariaDB adatbázis">
                    </div>
                <small class="info">Asztali alkalmazás letőltése szükséges a készülékünkre.</small>
            </div>
        </section>
        <section>
            <!--wrapper-web-application-->
            <div class="wrapper-web-application">
                <h3>WEB alkalmazás</h3>
                <div class="wordpress-plugin">
                    <h4>WordPress bővítmény</h4> <br>
                    <p>A WordPress bővítmény felel közvetlenül az adatok szinkronizálásáért, illetve ez
                        tartalmazná a cron beállításokat is, amelyek az adatok szinkronizálásának “automatizációjáért“,
                        pontosabban az időbeni beállításaiért felel.</p>
                </div>
                <div class="wordpress-theme">
                    <h4>WordPress téma</h4> <br>
                    <p>A téma HTML, CSS(BootStrap), JavaScript, PHP, JQuery alapokkal rendelkezik.
                    Illetve egy adatbázis is szükséges a működéshez (MariaDB). Ezt szinkronizálja a bővítményt a
                    desktop applikációval.</p>
                </div>
                <div class="skewX">
                    <img :src="skewDark" alt="internetes kereskedelem">
                </div>
                <div class="skewX2">
                    <img :src="skewLight" alt="internetes kereskedelem">
                </div>
            
            </div>
        </section>
     <!--all pages footer to equal-->
    <footer>
        <AppFooter :name="'Egyszerűsítsd vállalkozásod velünk'" :imgsrc="companyLogo" />
    </footer>
</template>

<script setup>
import { ref } from 'vue';
import AppFooter from './AppFooter.vue';
import companyLogo from '../images/syncbundlelogo.png';
import rotateImageDatabase from '../images/rotatedatabase.jpg';
import skewDark from '../images/skewdark.jpg'
import skewLight from '../images/skewlight.jpg'

const show = ref(false);

const showSection = () =>
{
    show.value = !show.value;
};
</script>

<style scoped>
/* home page settings with css grid */
.wrapper
{
    max-width: 90%;
    display: grid;
    grid-template-columns: repeat(12, 1fr);
    grid-template-rows: auto;
    gap: 10px;
    justify-content: space-around;
    align-items: center;
    padding: 14px;
    background-color: var(--wrapper-background-color);
    border-radius: 5px;
    margin: 15px auto;
}
span
{
    grid-column: 1 / 6;
    grid-row: 1;
    background-color: hsl(323, 79%, 64%);
    color: var(--font-color);
    font-weight: var(--font-weight);
    font-size: 24px;
    padding: 10px;
    border-radius: 5px;
}

span h1
{
    text-align: center;
}
.tech
{
    grid-column: span 6;
    grid-row: 2;
    margin-top: 15px;
    font-size: 20px;
    font-weight: var(--secondary-font-weight);
    color: var(--font-color);
    text-align: center;
    letter-spacing: var(--letter-spacing);
}
.description
{
    grid-column: span 5;
    grid-row: 2;
    margin: 10px 5px;
    font-size: 20px;
    font-weight: var(--secondary-font-weight);
    color: var(--font-color);
    text-align: center;
    letter-spacing: var(--letter-spacing);
}
.description small
{
    font-weight:normal;
}
.whoocommerce
{
    grid-column: span 6;
    grid-row: 3;
    margin: 5px 5px;
    font-size: 20px;
    font-weight: var(--secondary-font-weight);
    color: var(--font-color);
    text-align: center;
    letter-spacing: var(--letter-spacing);
}
.action
{
    grid-column: span 12;
    grid-row: 4;
    margin: 15px;
    font-size: 20px;
    font-weight: var(--secondary-font-weight);
    color: hsl(341, 44%, 39%);
    text-align: center;
    letter-spacing: var(--letter-spacing);

}
.section
{
    grid-column: 1 / 12;
    grid-row: 5;
    margin: 25px 5px;
    font-size: 19px;
    font-weight: 600;
    color: var(--font-color);
    text-align: left;
    letter-spacing: var(--letter-spacing);
}
button
{
    color: hsl(0, 0%, 4%);
    font-weight: bold;
}
/*animation settings*/
.fade-enter-active,
.fade-leave-active
{
  transition: opacity 1.5s ease-in-out;
}

.fade-enter-from,
.fade-leave-to 
{
  opacity: 0;
}
/*breakpoint one: tablet and smaller laptop */
@media (max-width: 1033px)
{
    .wrapper
    {
        max-width: 95%;
        align-items: stretch;
        
    }
    span
    {
        grid-column: 2 / 9;
        grid-row: 1;
        font-size: 23px;
    }
    .tech
    {
        grid-column: span 5;
        margin-top: 10px;
        font-size: 18.5px;
    }
    .description
    {
        grid-column: span 6;
        margin: 10px;
        font-size: 18.5px;
    }
    .whoocommerce
    {
        grid-column: span 8;
        grid-row: 3;
        margin: 7px;
        font-size: 18.5px;
    }

}

/*breakpoint two: smaller  tablet and bigger phone */
@media (max-width: 886px)
{
    .wrapper
    {
        max-width: 95%;
        gap: 8px;
        align-items: flex-start;
        padding: 10px;
    }
    span
    {
        grid-column: 2 / 9;
        grid-row: 1;
        font-size: 23px;
        padding: 10px;
    }
    .tech
    {
        grid-column: span 5;
        margin-top:  5px;
        font-size: 18.5px;
        text-align: start;
    }
    .description
    {
        grid-column: span 7;
        margin: 8px;
        font-size: 18.5px;
        text-align: center;
    }
    .whoocommerce
    {
        grid-column: span 8;
        grid-row: 3;
        margin: 7px;
    }
  
}

/*breakpoint three: phone */
@media (max-width: 768px)
{
    .wrapper
    {
        max-width: 97%;
        gap: 8px;
        justify-content: stretch;
        padding: 8px;
    }
    span
    {
        grid-column: span 12;
        font-size: 20px;
        padding: 10px;
        border-radius: 5px;
        text-align: start;
    }
    .tech
    {
        grid-column: span 12;
        grid-row: 2;
        margin: 5px;
        font-size: 17px;
        text-align: center;
    }
    .description
    {
        grid-column: span 12;
        grid-row: 3;
        margin: 5px;
        font-size: 17px;
        text-align: center;
    }
    .whoocommerce
    {
        grid-column: span 12;
        grid-row: 4;
        margin: 7px;
        font-size: 17px;
        text-align: center;
    }
    .action
    {
        grid-column: span 12;
        grid-row: 5;
        margin: 15px 0;
        font-size: 17px;
    }
    .section
    {
        grid-column: 1 / 12;
        grid-row: 6;
        margin: 10px;
        font-size: 17px;
        text-align: left;
    }

}
/*dekstop aplikation title settings */
.wrapper-dekstop-application
{
    max-width: 90%;
    display: grid;
    grid-template-columns: repeat(12, 1fr);
    grid-template-rows: auto;
    gap: 10px;
    justify-content: space-evenly;
    align-items: stretch;
    padding: 15px;
    background-color: var(--wrapper-background-color);
    border-radius: 5px;
    margin: 0 auto;
}
h2
{
    grid-column: 1 / 6;
    grid-row: 1;
    background-color: hsl(323, 79%, 64%);
    color: var(--font-color);
    font-weight: var(--font-weight);
    font-size: 24px;
    text-align: center;
    padding: 10px;
    border-radius: 5px;
}

.description-dekstop-application
{
    grid-column: 1 / 8;
    grid-row: 2;
    margin: 10px;
    font-size: 20px;
    font-weight: var(--secondary-font-weight);
    color: var(--font-color);
    text-align: justify;
    letter-spacing: var(--letter-spacing);
}

.mariadbimage
{
    grid-column: 8 / 12;
    grid-row: 2;
}
.mariadbimage img
{
    width: 500px;
    border-radius: 50%;
    padding: 10px;
    
}
.info
{
    grid-column: 9/ 12;
    grid-row: 1;
    font-weight: bold;
}

/*breakpoint one: tablet and smaller laptop */
@media (max-width: 1033px)
{
    .wrapper-dekstop-application
    {
        max-width: 95%;
        align-items: stretch;
        
    }
    h2
    {
        grid-column: 1 / 5;
        font-size: 24px;
       
    }
    
    .description-dekstop-application
    {
        grid-column: span 7;
        margin: 10px;
        font-size: 18.5px;
    }
    .mariadbimage
    {
        grid-column: 8 / 12;
        grid-row: 2;
    }
  

}

/*breakpoint two: smaller  tablet and bigger phone */
@media (max-width: 886px)
{
    .wrapper-dekstop-application
    {
        max-width: 95%;
        gap: 8px;
        align-items: flex-start;
        padding: 10px;
    }
    h2
    {
        font-size: 21px;
    }
    .description-dekstop-application
    {
        grid-column: span 10;
    }
    .mariadbimage
    {
        grid-column: 4 / 9;
        grid-row: 3;
    }
}

/*breakpoint three: phone */
@media (max-width: 768px)
{
    .wrapper-dekstop-application
    {
        max-width: 97%;
        gap: 8px;
        justify-content: stretch;
        padding: 8px;
    }
    h2
    {
        grid-column: 1 / 7;
        font-size: 21px;
    }
    .description-dekstop-application
    {
        grid-column: span 12;
        font-size: 17px;
        margin: 5px;
    }
    .mariadbimage
    {
       display: none;
    }
}
/*web aplikation title settings */
.wrapper-web-application
{
    max-width: 90%;
    display: grid;
    grid-template-columns: repeat(12, 1fr);
    grid-template-rows: auto;
    gap: 10px;
    justify-content: space-evenly;
    align-items: center;
    padding: 10px;
    text-align: justify;
    background-color: var(--wrapper-background-color);
    border-radius: 5px;
    margin: 15px auto;

}
h3
{
    grid-column: 1 / 6;
    grid-row: 1;
    background-color: hsl(323, 79%, 64%);
    color: var(--font-color);
    font-weight: var(--font-weight);
    font-size: 24px;
    text-align: center;
    padding: 10px;
    border-radius: 5px;
}
.wordpress-plugin
{
    grid-column: span 6;
    text-align: justify;
    grid-row: 2;
    margin: 10px 0;
    font-size: 19px;
    font-weight: var(--secondary-font-weight);
    color: var(--font-color);
    text-align: center;
    letter-spacing: var(--letter-spacing);

}
.wordpress-theme
{
    text-align: justify;
    grid-column: span 6;
    grid-row: 2;
    margin: 10px 0;
    font-size: 19px;
    font-weight: var(--secondary-font-weight);
    color: var(--font-color);
    text-align: center;
    letter-spacing: var(--letter-spacing);

}
h4
{
    padding: 10px;
    font-size: 20px;
    border-radius: 5px;
    background-color: var(--font-color);
    color: hsl(323, 79%, 64%);
}
.skewX
{
    grid-column: 8 / 11;
    grid-row: 4;
    margin-bottom: 20px;
    
}
.skewX img
{
    margin: 15px 0;
    width: 500px;
    transform: scale(1.3);
    transform-origin:  50% 50%;
    border-radius: 3px;
    transition: all 1s ease-in;
    
}
.skewX2
{
    grid-column: 2 / 5;
    grid-row: 4;
    margin-bottom: 20px;
}
.skewX2 img
{
    margin: 15px 0;
    width: 500px;
    transform: scale(1.3);
    transform-origin:  50% 50%;
    border-radius: 3px;
    transition: all 1s ease-in;
}
.skewX img:hover,
.skewX2 img:hover
{
    cursor: pointer;
    transform: skew(0);
    transition: all 1s ease-in-out;
}

/*breakpoint one: tablet and smaller laptop */
@media (max-width: 1033px)
{
    .wrapper-web-application
    {
        max-width: 95%;
        align-items: stretch;
        
    }
    h3
    {
        grid-column: 1 / 5;
        font-size: 24px;
       
    }
    
    .wordpress-plugin
    {
        font-size: 18.5px;
    }
    .wordpress-theme
    {
        font-size: 18.5px;
    }
  

}

/*breakpoint two: smaller  tablet and bigger phone */
@media (max-width: 886px)
{
    .wrapper-web-application
    {
        max-width: 95%;
        gap: 8px;
        align-items: flex-start;
        padding: 10px;
    }
    h3
    {
        font-size: 23px;
        
    }
    .wordpress-plugin
    {
        font-size: 19.7px;
    }
    .wordpress-theme
    {
        font-size: 19.7px;
    }
}

/*breakpoint three: phone */
@media (max-width: 768px)
{
    .wrapper-web-application
    {
        max-width: 97%;
        gap: 8px;
        justify-content: stretch;
        padding: 8px;
    }
    h3
    {
        grid-column: 1 / 7;
        font-size: 21px;
    }
    .wordpress-plugin
    {
        font-size: 17.5px;
    }
    .wordpress-theme
    {
        font-size: 17.5px;
    }
    .skewX,
    .skewX2
    {
        display: none;
    }  
}
/*column and row definition*/
@media (max-width:650px)
{
    .wordpress-plugin
    {
        grid-column: span 10;
        grid-row: 2;
    }
.wordpress-theme
    {
        grid-column: span 10;
        grid-row: 3;
    }

}

</style>