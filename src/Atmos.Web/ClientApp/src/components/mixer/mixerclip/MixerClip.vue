<template>
    <div class="mixer-clip">
            <div class="sound" v-bind:class="{ selected: playing }">
                <img :src="icon" class="card-img-top" alt="..." @click="onSelected(togglePlayback, playing)" v-bind:class="{ selectedClip: playing }">
                <div class="slider-wrap">
                    <vue-slider v-model="slider" />
                    <p style="visibility: hidden">{{sliderValueToDecimal}}</p>
                </div>
            </div>
        </div>
</template>

<script>
    import VueHowler from "vue-howler";
    import VueSlider from 'vue-slider-component'
    import 'vue-slider-component/theme/antd.css'
    
    import "./style/MixerClip.scss";
    
    export default {
        name: "MixerClip",
        mixins: [VueHowler],
        components: {
            
            VueSlider
        },
        props: {
            title: String,
            description: String,
            sources: Array,
            icon: String,
            clipPlaying: Boolean,
            clipvolume: Number
        },
        methods: {
            onSelected: function() {
                this.togglePlayback();
                if (!this.playing) {
                    this.isPlaying = true;
                    this.$emit('playing');
                } else {
                    this.isPlaying = false;
                    this.$emit('stopped');
                }
            }
        },
        computed: {
            sliderValueToDecimal() {
                let val = this.slider;
                this.setVolume(val);
                return val;
            }
        },
        watch: {
            clipPlaying(play) {
                if (play) {
                    this.play();
                    this.slider = this.clipvolume * 100;
                    this.setVolume(this.clipvolume);
                } else {
                    this.stop();
                    this.slider = this.clipvolume * 100;
                }
            }
        },
        data() {
            return {
                slider: 50,
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
        opacity: 0.2;
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
        .slider-wrap {
            visibility: visible;
        }
    }
    .slider-wrap {
        padding-left: 4em;
        padding-right: 4em;
        padding-top: 20px;
        opacity: 0.2;
        transition: 0.70s;
    }
    .selected > .slider-wrap {
        opacity: 1;
    }
    .selected > img {
        opacity: 1 !important;
    }
</style>