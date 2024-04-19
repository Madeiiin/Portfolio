import React, {Component} from 'react';
import Carousel from 'react-bootstrap/Carousel';
import Teamjpg from '../assets/Team.jpg';
import Team2jpg from '../assets/Team2.jpg';
import Team3jpg from '../assets/Team3.jpg';
import Officejpg from '../assets/Office.jpg';

class CarouselBox extends Component {
    render() {
        return (
                <Carousel>
                    <Carousel.Item>
                        <img
                            className={" w-100  "}
                            src={Teamjpg}
                            alt={"FrontEnd Команда"}
                            height={1245}
                        />
                        <Carousel.Caption>
                            <div className={"DivTeam"}>
                            <h3>Бравая команда разработчиков клиентской части сайта.</h3>
                            <p>Лучшая команда Front-End разработчиков рада представить самый современный дизайн NFT-магазина.</p>
                            </div>
                        </Carousel.Caption>
                    </Carousel.Item>
                    <Carousel.Item>
                        <img
                            className={"d-block w-100"}
                            src={Team2jpg}
                            alt={"BackEnd Команда"}
                            height={1245}
                        />
                        <Carousel.Caption>
                            <div className={"DivTeam"}>
                            <h3>Единственный и неповторимый разработчик серверной части сайта.</h3>
                            <p>Гений инженерной мысли. Гуру в области Back-End разработки. Только благодаря ему мы имеем серверную сторону нашего магазина.</p>
                            </div>
                        </Carousel.Caption>
                    </Carousel.Item>
                    <Carousel.Item>
                        <img
                            className={"d-block w-100"}
                            src={Team3jpg}
                            alt={"БД Команда"}
                            height={1245}
                        />
                        <Carousel.Caption>
                            <div className={"DivTeam"}>
                            <h3>Разработчик с многолетним опытом, ответственный за функционирование базы данных.</h3>
                            <p>Именно его следует винить, если ваши личные данные будут украдены.</p>
                            </div>
                        </Carousel.Caption>
                    </Carousel.Item>
                    <Carousel.Item>
                            <img
                                className={"d-block w-100"}
                                src={Officejpg}
                                alt={"Офис команды"}
                                height={1245}
                            />
                        <Carousel.Caption>
                            <div className={"DivTeam"}>
                                <h3>Наш офис.</h3>
                                <p>В этом уютном пентхаусе наша команда творит чудеса.</p>
                            </div>
                        </Carousel.Caption>
                    </Carousel.Item>
                </Carousel>


        );
    }
}

export default CarouselBox;