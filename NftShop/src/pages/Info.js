import React, {Component} from 'react';
import {Col, Container, Nav, Row, Tab} from "react-bootstrap";
import T1 from '../assets/t1.jpg'
import T2 from '../assets/t2.png'
import T3 from '../assets/t3.jpg'
import T4 from '../assets/t4.jpg'
import BW from '../assets/BestWorker.png'
import BC from '../assets/BestCustomer.png'
import MP from '../assets/Map.png'
import BC2 from '../assets/BestCustomer2.jpg'
class Info extends Component {
    render() {
        return (
            <Container>

                <Tab.Container id={"left-tabs"} defaultActiveKey={"one"}>
                    <Row>
                        <Col sm={3} >
                            <Nav variant={"pills"} className={"flex-column mt-2"}>
                                <Nav.Item>
                                    <Nav.Link eventKey={"one"}>Почему стоит выбрать наш магазин?</Nav.Link>
                                </Nav.Item>
                                <Nav.Item>
                                    <Nav.Link eventKey={"two"}>Отзывы</Nav.Link>
                                </Nav.Item>
                                <Nav.Item>
                                    <Nav.Link eventKey={"three"}>Лучший сотрудник месяца</Nav.Link>
                                </Nav.Item>
                                <Nav.Item>
                                    <Nav.Link eventKey={"four"}>Самый активный покупатель</Nav.Link>
                                </Nav.Item>
                                <Nav.Item>
                                    <Nav.Link eventKey={"five"}>Адреса наших розничных магазинов</Nav.Link>
                                </Nav.Item>
                            </Nav>
                        </Col>
                        <Col sm={9}>
                            <Tab.Content>
                                <Tab.Pane eventKey={"one"}>
                                    <img
                                    src={T1}
                                    className={"d-block w-100 mt-2 InfoImage"}
                                    />
                                    <div className={"DivDescription"}>
                                        У нас самый большой в мире асортимент NFT товаров. Кроме того, у нас демократичные цены.
                                        Также мы предоставляем возможность оформления кредита или рассрочки для покупки какого-либо товара.
                                    </div>
                                </Tab.Pane>
                                <Tab.Pane eventKey={"two"}>
                                    <img
                                        src={T2}
                                        className={"d-block w-50 mt-2 InfoImage"}
                                    />
                                    <img
                                        src={T3}
                                        className={"d-block w-50 mt-2 InfoImage"}
                                    />
                                    <img
                                        src={T4}
                                        className={"d-block w-50 mt-2 InfoImage"}
                                    />
                                    <div className={"DivDescription"}>
                                        У нас огромное количество довольных клиентов. Ни один магазин с нами не сравнится.
                                    </div>
                                </Tab.Pane>
                                <Tab.Pane eventKey={"three"}>
                                    <img
                                        src={BW}
                                        className={"d-block w-100 mt-2 InfoImage "}
                                        height={"700"}
                                    />
                                    <div className={"DivDescription"}>
                                        Наиль Миназов aka Пожилая Машина, также известен под псевдонимом Ядерный Титбит
                                    </div>
                                </Tab.Pane>
                                <Tab.Pane eventKey={"four"}>
                                    <img
                                        src={BC}
                                        className={"d-block w-100 mt-2 InfoImage "}
                                        height={"700"}
                                    />
                                    <div className={"DivDescription"}>
                                        Рамзес Миназов aka Пожилая Бетономешалка
                                    </div>
                                </Tab.Pane>
                                <Tab.Pane eventKey={"five"}>
                                    <img
                                        src={MP}
                                        className={"d-block w-100 mt-2 InfoImage "}
                                        height={"700"}
                                    />
                                    <div className={"DivDescription"}>
                                        Наши точки расположены:
                                        <ul><li>на Кировском рынке, палатка номер 217, между Фуршетом Фуршвахтовичем и Шухратом Азатовичем;  </li>
                                            <li>в подземном переходе на пересечении ул. Советской Армии и Московского шоссе;  </li>
                                            <li>в ТЦ "Московский", секция 12, справа от овощной палатки.  </li>
                                        </ul>
                                    </div>
                                </Tab.Pane>
                            </Tab.Content>
                        </Col>
                    </Row>

                </Tab.Container>
            </Container>
        );
    }
}

export default Info;