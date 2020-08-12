<template>
    <div class="sound-object">
        <div class="sound" @click="startPlaying(togglePlayback, playing)">
            <img :src="icon" class="card-img-top" alt="...">
            <div class="slider-wrap">
                <slider
                        min="0"
                        max="100"
                        hideLabel="true"
                        v-model="slider"
                        class="slider-ben"
                ></slider>
            </div>
        </div>
    </div>
</template>

<script>
    
    import VueHowler from "vue-howler";
    import Slider from "vue-custom-range-slider";
    import "vue-custom-range-slider/dist/vue-custom-range-slider.css";
    
    export default {
        mixins: [VueHowler],
        name: "SoundObject",
        props: {
            title: String,
            description: String,
            audioSources: Array,
            icon: String
        },
        components: {
            Slider
        },
        data() {
            return {
                slider: "50",
            };
        },
        methods: {
            startPlaying: function (playFunc, playing) {
                if (!playing) {
                    console.log('Playing')
                    this.$emit('playing');
                    playFunc();
                } else {
                    console.log('Stopped Playing')
                    this.$emit('stopped');
                    playFunc();
                }
                console.log(playFunc)
            }
        }
    }
</script>

<style scoped>
    .sound-object {
        margin-bottom: 1em;
    }
    .sound {
        text-align: center;
    }
    .sound > img {
        opacity: 50%;
        width: 60%;
        margin-left: auto;
        margin-right: auto;
        transition: 0.8s;
    }
    .sound > img:hover {
        opacity: 100%;
        width: 60%;
        margin-left: auto;
        margin-right: auto;
        cursor: pointer;
    }
    #sound-options > div.row > div:nth-child(1) > div > div > div > div > div.slider__label {
        visibility: hidden !important;
    }
    .slider-ben {
        opacity: 50%;
        margin-top: 10px;
    }
    .slider-wrap {
        padding-left: 4em;
        padding-right: 4em;
    }
</style>