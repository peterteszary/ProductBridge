<template>
    <main>
        <div class="image-wrapper">
            <!--person one-->
            <div class="wrapper">
                <div class="profile-one"><img style="border-radius: 3px;" :src="profilepicture" alt="profilkép"></div>
                <div class="name">Tesszáry Péter</div>
                <div class="introduction">WordPress weboldalak fejlesztésével foglalkozom, fontos
                     számomra az ügyfelekkel való jó kapcsolatot és a minőség minden minden lehetséges döntésben 
                     közösen részt venni ezáltal is biztosítani azt hogy a végcél mindeni számára megfelelő legyen.</div>
            </div>
            <!--person two-->
            <div class="wrapper-two">
                <div class="profile-two"><img style="border-radius: 3px;" :src="profilepicture" alt="profilkép"></div>
                <div class="name-two">Pernyész Dániel</div>
                <div class="introduction-two">Kezdő programozóként a Java programozási nyelv területén 
                    kezdtem a munkám mivel ez a programozási nyelv rengeteg lehetőséget biztosít , platformfüggetlen
                     és széles körben elterjedt természetesen van hátránya is mégpedig a nehezen tanulhatóság. </div>
            </div>
            <!--person three-->
            <div class="wrapper-three">
                <div class="profile-three"><img style="border-radius: 3px;" :src="profilepicture" alt="profilkép"></div>
                <div class="name-three">Bagi Péter</div>
                <div class="introduction-three">Junior fejlesztőként a webprogramozás területén indultam el
                     ez az irány számomra a látványosság miatt érdekes, ismerem a JavaScript keretrendszerekben
                    rejlő lehetőségeket és úgy gondolom hogy mindig a minőségi új technikákat kell használni.</div>
            </div>
            <br>
            <!--images slider-->
            <Carousel/>
        </div> 
    </main>
    <!--all pages  footer to equal-->
    <footer>
        <AppFooter :name="'Egyszerűsítsd vállalkozásod velünk'" :imgsrc="companyLogo" />
    </footer>
</template>

<script setup>
import AppFooter from '../components/AppFooter.vue';
import companyLogo from '../images/syncbundlelogo.png';
import profilepicture from '../images/profilepicture.png';
import Carousel from '../components/Carousel.vue';

</script>

<style scoped>
/*background-image settings */
.image-wrapper
{
    background-image: url('../images/woocommerce.jpg');
    position: sticky;
    background-size: contain;
    background-repeat: repeat;
}
/* about page settings with css grid 

    person one settings */
.wrapper
{
    max-width: 90%;
    display: grid;
    grid-template-columns: repeat(12, 1fr);
    grid-template-rows: auto;
    justify-content: center;
    align-items: center;    
    background-color: var(--wrapper-background-color);
    margin: 20px auto;
    border-radius: 5px;
}
.profile-one
{
    grid-column: 1 / 3;
    grid-row: 1;
    padding: 5px;

}
.name
{
    grid-column: 3 / 5;
    grid-row: 1;
    margin: 5px;
    color: var(--font-color);
    font-weight: var(--secondary-font-weight);
    letter-spacing: var(--letter-spacing);
    background-color: hsl(44, 86%, 45%);
    padding: 3px;
    border-radius: 3px;
}
.introduction
{
    grid-column: 6 / 11;
    grid-row: 1;
    margin: 3px;
    color: var(--font-color);
    font-weight: var(--secondary-font-weight);
    letter-spacing: var(--letter-spacing);
}
/*person two settings */
.wrapper-two
{
    max-width: 90%;
    display: grid;
    grid-template-columns: repeat(12, 1fr);
    grid-template-rows: auto;
    justify-content: center;
    align-items: center;
    background-color: var(--wrapper-background-color);
    margin: 20px auto;
    border-radius: 5px;
}
.profile-two
{
    grid-column: 1 / 3;
    grid-row: 2;
    padding: 5px;

}
.name-two
{
    grid-column: 3 / 5;
    grid-row: 2;
    margin: 5px;
    color: var(--font-color);
    font-weight: var(--secondary-font-weight);
    letter-spacing: var(--letter-spacing);
    background-color: hsl(44, 86%, 45%);
    padding: 3px;
    border-radius: 3px;
}
.introduction-two
{
    grid-column: 6 / 11;
    grid-row: 2;
    margin: 3px;
    color: var(--font-color);
    font-weight: var(--secondary-font-weight);
    letter-spacing: var(--letter-spacing);
}
/*person three settings */
.wrapper-three
{
    max-width: 90%;
    display: grid;
    grid-template-columns: repeat(12, 1fr);
    grid-template-rows: auto;
    justify-content: center;
    align-items: center;
    background-color: var(--wrapper-background-color);
    margin: 20px auto;
    border-radius: 5px;
}
.profile-three
{
    grid-column: 1 / 3;
    grid-row: 3;
    padding: 5px;

}
.name-three
{
    grid-column: 3 / 5;
    grid-row: 3;
    margin: 5px;
    color: var(--font-color);
    font-weight: var(--secondary-font-weight);
    letter-spacing: var(--letter-spacing);
    background-color: hsl(44, 86%, 45%);
    padding: 3px;
    border-radius: 3px;
}
.introduction-three
{
    grid-column: 6 / 11;
    grid-row: 3;
    margin: 3px;
    color: var(--font-color);
    font-weight: var(--secondary-font-weight);
    letter-spacing: var(--letter-spacing);
}
/*breakpoint one: tablet and smaller laptop */
@media (max-width: 1033px)
{
    .wrapper
    {
        max-width: 95%;
        justify-content: space-between;
    }
    .profile-one
    {
        grid-column: 2 / 7;
        grid-row: 1;
        padding: 3px;
    }
    .name
    {
        grid-column: 1 / 4;
        grid-row: 2;
    }
    .introduction
    {
        grid-column: 6 / 12;
        grid-row: 2;
    }
    .wrapper-two
    {
        justify-content: space-between;
    }
    .profile-two
    {
        grid-column: 2 / 7;
        grid-row: 2;
        padding: 3px;
    }
    .name-two
    {
        grid-column: 1 / 4;
        grid-row: 3;
    }
    .introduction-two
    {
        grid-column: 6 / 12;
        grid-row: 3;
    }
    .wrapper-three
    {
        justify-content: space-between;
    }
    .profile-three
    {
        grid-column: 2 / 7;
        grid-row: 2;
        padding: 3px;
    }
    .name-three
    {
        grid-column: 1 / 4;
        grid-row: 3;
    }
    .introduction-three
    {
        grid-column: 6 / 12;
        grid-row: 3;
    }
}
/*breakpoint two: smaller tablet and phone of all size */
@media (max-width: 768px)
{
    .wrapper
    {
        max-width: 97%;
        justify-content: space-between;
    }
    .profile-one
    {
        grid-column: 2 / 7;
        grid-row: 1;
        padding: 3px;
    }
    .name
    {
        grid-column: 7 / 11;
        grid-row: 1;
    }
    .introduction
    {
        grid-column: span 12;
        grid-row: 2;
    }
    .wrapper-two
    {
        max-width: 97%;
        justify-content: space-between;
    }
    .profile-two
    {
        grid-column: 2 / 7;
        grid-row: 2;
        padding: 3px;
    }
    .name-two
    {
        grid-column: 7 / 11;
        grid-row: 2;
    }
    .introduction-two
    {
        grid-column: span 12;
        grid-row: 3;
    }
    .wrapper-three
    {
        max-width: 97%;
        justify-content: space-between;
    }
    .profile-three
    {
        grid-column: 2 / 7;
        grid-row: 2;
        padding: 3px;
    }
    .name-three
    {
        grid-column: 7 / 11;
        grid-row: 2;
    }
    .introduction-three
    {
        grid-column: span 12;
        grid-row: 3;
    }

}



</style>