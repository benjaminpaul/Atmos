<template>
    <div class="mixer-clip">
            <div class="sound" v-bind:class="{ selected: playing }">
                <img :src="icon" class="card-img-top" alt="..." @click="onSelected(togglePlayback, playing)" v-bind:class="{ selectedClip: playing }">
                <div class="slider-wrap">
                    <slider
                            min="0"
                            max="100"
                            hideLabel
                            v-model="slider"
                            class="slider-style"
                    ></slider>
                    
                    <p style="visibility: hidden">{{sliderValueToDecimal}}</p>
                </div>
            </div>
        </div>
</template>

<script>
    import VueHowler from "vue-howler";
    import Slider from "vue-custom-range-slider";
    
    import "./MixerClip.scss";
    
    export default {
        name: "MixerClip",
        mixins: [VueHowler],
        components: {
            Slider
        },
        created() {
            console.log('Created')
            this.loop = true;
        },
        props: {
            title: String,
            description: String,
            sources: Array,
            icon: String
        },
        methods: {
            onSelected: function() {
                this.togglePlayback();
                if (!this.playing) {
                    console.log('Playing')
                    this.isPlaying = true;
                    this.$emit('playing');
                } else {
                    this.isPlaying = false;
                    console.log('Stopped')
                    this.$emit('stopped');
                }
            }
        },
        computed: {
            sliderValueToDecimal: function () {
                let val = parseInt(this.slider).toFixed(2) / 100;
                console.log(this);
                this.setVolume(val);
                return val;
            }
        },
        data() {
            return {
                slider: "50",
                isPlaying: false
            }
        }
    }
</script>

<style lang="scss" scoped>
    $slider-track-background: red;

    .mixer-clip {
        margin-bottom: 1em;
        cursor: pointer;
    }
    .sound {
        text-align: center;
    }
    .sound > img {
        opacity: 0.5;
        width: 60%;
        margin-left: auto;
        margin-right: auto;
        transition: 0.8s;
        background-color: rgba(255, 255, 255, 0.2);
        border-radius: 20px;
    }
    .sound > img.selected {
        opacity: 1;
        border: 1px solid white;
    }
    #sound-options > div.row > div:nth-child(1) > div > div > div > div > div.slider__label {
        visibility: hidden !important;
    }

    .slider-style {
        opacity: 0.3;
        margin-top: 10px;
    }
    
    @media (min-width: 768px) {
        .slider-ben {
            visibility: visible;
        }
    }
    .slider-wrap {
        padding-left: 4em;
        padding-right: 4em;
    }
    .selected > img {
        opacity: 1 !important;
    }
</style>