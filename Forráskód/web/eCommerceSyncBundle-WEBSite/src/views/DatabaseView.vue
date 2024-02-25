<template>
    <main>
      <div class="wrapper">
        <h1>Adatbázisinformáció</h1> <button class="clickanimate"><i @click="clickicon()" class="bi bi-arrow-clockwise"></i></button>
        <Transition name="bounce" mode="in-out">
            <div class="mariadb-description" v-if="visible">
                A MariaDB egy nyílt forrású relációs adatbázis-kezelő rendszer, amely az SQL adatbázisokhoz kínál alternatívát. 
                A MariaDB-t az eredeti MySQL alkalmazásból hozták létre, miután az Oracle megvásárolta a MySQL fejlesztőit.
                A MariaDB nyílt forráskódú projekt, amelyet a közösség és az üzleti szereplők egyaránt támogatnak.
                Az adatbázis-kezelő rendszer nyílt forráskódú, tehát bárki szabadon felhasználhatja, módosíthatja és terjesztheti a kódját. 
                Az adatbázis-kezelő rendszer könnyen telepíthető, és támogatja a legtöbb szabványos SQL parancsot és a legtöbb adatbázis-alkalmazást.
            </div>
            <div class="mariadb-description-hidden" v-else>
                A MariaDB fő célja az, hogy egy olyan adatbázis-kezelő rendszert biztosítson, amely könnyen telepíthető, használható és skálázható, miközben 
                javítja a teljesítményt és a biztonságot. Az adatbázis-kezelő rendszer az ACID (atómi, konzisztens, elszigetelt és tartózkodó) elveknek megfelelően 
                működik, ami azt jelenti, hogy biztosítja az adatok konzisztenciáját és az adatok állandóságát.
                A MariaDB több platformon is elérhető, többek között Linux, Windows és macOS rendszereken is használható. Az adatbázis-kezelő rendszer számos
                funkcióval rendelkezik, amelyek közül a legfontosabbak a következők.
           </div>
        </Transition>
      </div>
      <div class="wrapper-mariadb-property">
        <div class="mariadb-property-description">
                <ul>
                    <Transition>
                        <li>
                            <button @click="mariadbproperty()"><strong>Skálázhatóság</strong>
                                <i :class="[property ? 'bi bi-three-dots-vertical p-2' : 'bi bi-three-dots p-2']"></i> 
                            </button> 
                            <p v-show="property">A MariaDB egyszerűen skálázható, ami azt jelenti, hogy nagyobb 
                            adatbázisokkal is megbirkózik, és nagyobb terhelést is elbír.</p>
                        </li>
                    </Transition>
                    <Transition>
                        <li>
                            <button @click="mariadbproperty()"><strong>Biztonság</strong>
                            </button> 
                            <p v-show="property"> Az adatbázis-kezelő rendszer számos biztonsági funkcióval rendelkezik, például a titkosítással,
                                 amely lehetővé teszi az adatok védelmét a külső támadásokkal szemben.</p>
                        </li>
                    </Transition>
                    <Transition>
                        <li>
                            <button @click="mariadbproperty()"><strong>Rugalmasság</strong>
                            </button> 
                            <p v-show="property">Az adatbázis-kezelő rendszer rugalmas és könnyen testreszabható, így az egyedi igényekhez is 
                                alkalmazkodni tud.</p>
                        </li>
                    </Transition>
                    
                        <li>
                         <p style="color: dimgrey;">A MariaDB gyors és hatékony működést kínál, ami lehetővé teszi a nagyobb adatmennyiségek hatékony kezelését és feldolgozását.</p>
                        </li>
                    
                   
            </ul>
        </div>
      </div>
    </main>
     <!--all pages  footer to equal-->
     <footer>
        <AppFooter :name="'Egyszerűsítsd vállalkozásod velünk'" :imgsrc="companyLogo" />
    </footer>
</template>

<script setup>
import { ref } from 'vue';
import AppFooter from '../components/AppFooter.vue';
import companyLogo from '../images/syncbundlelogo.png';

const visible = ref(false);
const property = ref(false);
const mariadbproperty = () =>
{
    property.value = !property.value
};
const clickicon = () =>
{
    visible.value = !visible.value

};

</script>

<style scoped>
/* database page settings with css grid */
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
h1
{
    grid-column: 1 / 6;
    grid-row: 1;
    background-color: hsl(323, 79%, 64%);
    color: var(--font-color);
    font-weight: var(--font-weight);
    font-size: 24px;
    padding: 10px;
    text-align: center;
    border-radius: 5px;
}
.clickanimate
{
    grid-column: 6 / 7;
    grid-row: 1;
    font-size: 24px;
    font-weight: bold;
}
/*description animation */
.bounce-enter-active
{
    animation: bounce-in .5s ease;
}
.bounce-leave-active
{
    animation: bounce-in .5s reverse;
}
@keyframes bounce-in
{
    0%
    {
        transform: scale(.60);
    }
    50%
    {
        transform: scale(.25);
    }
    100%
    {
        transform: scale(1);
    }
}
.mariadb-description
{
    grid-column: 1 / 12;
    grid-row: 2;
    margin: 10px;
    font-size: 20px;
    font-weight: var(--secondary-font-weight);
    color: var(--font-color);
    text-align: justify;
    letter-spacing: var(--letter-spacing);
}
.mariadb-description-hidden
{
    grid-column: 1 / 12;
    grid-row: 2;
    margin: 10px;
    padding: 8px;
    border-radius: 3px;
    font-size: 20px;
    font-weight: var(--secondary-font-weight);
    color: rgb(225, 44, 50);
    background-color: var(--font-color);
    text-align: justify;
    letter-spacing: var(--letter-spacing);
}
.wrapper-mariadb-property
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
.mariadb-property-description
{
    grid-column: 5 / 9;
    justify-content: center;
    text-align: center;
    align-items: center;
    text-align: justify;
    
}

.mariadb-property-description ul li
{
    margin-top: 10px;
    font-size: 20px;
}

/*breakpoint one: tablet and smaller laptop */
@media (max-width: 1033px)
{
    .wrapper
    {
        max-width: 95%;
        align-items: stretch;
        
    }
   h1
    {
        grid-column: 2 / 9;
        text-align: start;
    }
    .clickanimate
    {
        grid-column: 11 / 11;
        grid-row: 1;
    }
    .mariadb-description
    {
        grid-column: 1  / 12;
        grid-row: 3;
       
    }
    .mariadb-description-hidden
    {
        grid-column: 1  / 12;
        grid-row: 3;
      
    }

}

/*breakpoint two: smaller  tablet and bigger phone */
@media (max-width: 886px)
{
    .wrapper
    {
        max-width: 97%;
        gap: 8px;
        align-items: flex-start;
       
    }
    h1
    {
        grid-column: 1 / 10;
    }
    .mariadb-description
    {
        grid-column: 1  / 12;
        grid-row: 2;
       
    }
    .mariadb-description-hidden
    {
        grid-column: 1  / 12;
        grid-row: 2;
      
    }
    .mariadb-property-description
    {
        grid-column: 4 / 11;
        justify-content: center;
        text-align: center;
        align-items: center;
        text-align: justify;
    }
}
/*breakpoint three: phone */
@media (max-width: 768px)
{
    .wrapper
    {
        max-width: 98%;
        gap: 7px;
        justify-content: stretch;
        padding: 3px;
    }
    h1
    {
        grid-column: 1 / 12;
        
    }
    .clickanimate
    {
        grid-column: 11 / 11;
        grid-row: 2;
    }
    .mariadb-description
    {
        grid-column: 1  / 12;
        grid-row: 3;
        font-size: 19.5px;
       
    }
    .mariadb-description-hidden
    {
        grid-column: 1  / 12;
        grid-row: 3;
        font-size: 19.5px;
      
    }
    .mariadb-property-description
    {
        grid-column: 1 / 12;
        justify-content: center;
        text-align: center;
        align-items: center;
        text-align: justify;
    }
}
</style>