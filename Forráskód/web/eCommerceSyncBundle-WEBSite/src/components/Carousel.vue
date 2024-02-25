<template>
    <!--bootstrap carousel settings-->
    <div class="container">
        <div class="row">
            <div class="col col-lg-8 col-md-8 my-1 mx-auto">
                <div id="carouselExampleDark" class="carousel carousel-dark slide" data-bs-ride="carousel">
                    <div class="carousel-indicators">
                        <button type="button" data-bs-target="#carouselExampleDark" data-bs-slide-to="0" class="active" aria-current="true" aria-label="Slide 1"></button>
                        <button type="button" data-bs-target="#carouselExampleDark" data-bs-slide-to="1" aria-label="Slide 2"></button>
                        <button type="button" data-bs-target="#carouselExampleDark" data-bs-slide-to="2" aria-label="Slide 3"></button>
                    </div>
                        <div class="carousel-inner">
                            <div class="carousel-item active" data-bs-interval="1000">
                                <img :src="carouselItem4" class="d-block w-90">
                            </div>
                            <div class="carousel-item" data-bs-interval="2000">
                                <img :src="carouselItem2" class="d-block w-90">
                            </div>
                            <div class="carousel-item">
                                <img :src="carouselItem3" class="d-block w-90">
                            </div>
                        </div>
                    </div>
            </div>
        </div>
    </div>
</template>
<script setup>
//carousel images
import carouselItem2 from '../images/carousel-item-2.jpg';
import carouselItem3 from '../images/carousel-item-3.jpg';
import carouselItem4 from '../images/carousel-item-4.jpg';
</script>
<style scoped>
.carousel-inner
{
    border-radius: var(--carousel-inner-border-radius);
}

</style>
