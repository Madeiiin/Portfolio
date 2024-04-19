import React, {Component} from 'react';
import {Button, Card, Col, Container, FormText, Nav, Row, Tab} from "react-bootstrap";
import N1 from "../assets/n1.jpg";
import N2 from "../assets/n2.jpg";
import N3 from "../assets/n3.jpg";
import N4 from "../assets/n4.gif";
import N5 from "../assets/n5.gif";
import N6 from "../assets/n6.jpg";
import N7 from "../assets/n7.jpg";
import N8 from "../assets/n8.jpg";
import N9 from "../assets/n9.gif";
import N10 from "../assets/n10.gif";
import W1 from "../assets/w1.png";
import W2 from "../assets/w2.png";
import W3 from "../assets/w3.png";
import W4 from "../assets/w4.jpg";
import W5 from "../assets/w5.png";
import W6 from "../assets/w6.jpg";
import N11 from "../assets/n11.gif";
import N12 from "../assets/n12.gif";
import A1 from "../assets/a1.webp"
class Sales extends Component {
    render() {
        return (
    <>

        <Container>

            <Tab.Container id={"left-tabs"} defaultActiveKey={"one"}>
                <Row>
                    <Col sm={2} >
                        <Nav variant={"pills"} className={"flex-column mt-2"} style={{cursor: "pointer"}}>
                            <Nav.Item>
                                <Nav.Link eventKey={"one"}>Предложение дня!</Nav.Link>
                            </Nav.Item>
                            <Nav.Item>
                                <Nav.Link eventKey={"two"}>Анимированные NFT</Nav.Link>
                            </Nav.Item>
                            <Nav.Item>
                                <Nav.Link eventKey={"three"}>Wiedźmin NFT</Nav.Link>
                            </Nav.Item>

                        </Nav>
                    </Col>
                    <Col sm={9}>
                        <Tab.Content>
                            <Tab.Pane eventKey={"one"}>
                            <Row md={"4"} style={{
                                marginLeft: "100px",

                            }} >
                                <Card className={"m-2"} >
                                    <Card.Img
                                        variant={"top"}
                                        src={N1}
                                        height={"200"}
                                        width={"200"}
                                    />
                                    <Card.Body>
                                        <Card.Title style={{
                                            fontSize: "15px"
                                        }}> Funny Green Guy </Card.Title>
                                        <Card.Text>Забавный чел</Card.Text>
                                        <Button  variant={"outline-primary"} style={
                                            {
                                                borderRadius: "20px", marginBottom: "10px",
                                            }}>Купить</Button>
                                        <Card.Text className={"BTC"}>
                                            <FormText style={{textDecoration: "line-through", fontSize:"16.5px",
                                                color:"black", textDecorationColor:"red", textDecorationThickness:"3px"}}>0.1 </FormText> - 0.001
                                            <img
                                            src={"https://pngimg.com/uploads/bitcoin/small/bitcoin_PNG47.png"}
                                            height={"20px"}
                                            width={"20px"}

                                            />

                                        </Card.Text>
                                    </Card.Body>
                                </Card>

                                <Card className={"m-2"} >
                                    <Card.Img
                                        variant={"top"}
                                        src={N2}
                                        height={"200"}
                                        width={"200"}
                                    />
                                    <Card.Body>
                                        <Card.Title style={{
                                            fontSize: "15px"
                                        }}> Cool Russian Guy </Card.Title>
                                        <Card.Text>Крутой чел</Card.Text>
                                        <Button  variant={"outline-primary"} style={
                                            {
                                                borderRadius: "20px", marginBottom: "10px",
                                            }}>Купить</Button>
                                        <Card.Text className={"BTC"}>
                                            <FormText style={{textDecoration: "line-through", fontSize:"16.5px",
                                                color:"black", textDecorationColor:"red", textDecorationThickness:"3px"}}>1100 </FormText>
                                            - 100
                                            <img
                                                src={"https://pngimg.com/uploads/bitcoin/small/bitcoin_PNG47.png"}
                                                height={"20px"}
                                                width={"20px"}

                                            />

                                        </Card.Text>
                                    </Card.Body>
                                </Card>
                                <Card className={"m-2"} >
                                    <Card.Img
                                        variant={"top"}
                                        src={N3}
                                        height={"200"}
                                        width={"200"}
                                    />
                                    <Card.Body>
                                        <Card.Title style={{
                                            fontSize: "15px"
                                        }}> Imbecile Old Guy  </Card.Title>
                                        <Card.Text>Слабоумный чел</Card.Text>
                                        <Button variant={"outline-primary"} style={
                                            {
                                                borderRadius: "20px", marginBottom: "10px",
                                            }}>Купить</Button>
                                        <Card.Text className={"BTC"}>
                                            <FormText style={{textDecoration: "line-through", fontSize:"16.5px",
                                                color:"black", textDecorationColor:"red", textDecorationThickness:"3px"}}>0.25 </FormText>
                                            - 0.16
                                            <img
                                                src={"https://pngimg.com/uploads/bitcoin/small/bitcoin_PNG47.png"}
                                                height={"20px"}
                                                width={"20px"}

                                            />

                                        </Card.Text>
                                    </Card.Body>
                                </Card>
                                <Card className={"m-2"} >
                                    <Card.Img
                                        variant={"top"}
                                        src={A1}
                                        height={"200"}
                                        width={"200"}
                                    />
                                    <Card.Body>
                                        <Card.Title style={{
                                            fontSize: "15px"
                                        }}> Happy Madison Guy </Card.Title>
                                        <Card.Text>Смешной чел</Card.Text>
                                        <Button  variant={"outline-primary"} style={
                                            {
                                                borderRadius: "20px", marginBottom: "10px",
                                            }}>Купить</Button>
                                        <Card.Text className={"BTC"}>
                                            <FormText style={{textDecoration: "line-through", fontSize:"16.5px",
                                                color:"black", textDecorationColor:"red", textDecorationThickness:"3px"}}>400 </FormText>
                                            - 300
                                            <img
                                                src={"https://pngimg.com/uploads/bitcoin/small/bitcoin_PNG47.png"}
                                                height={"20px"}
                                                width={"20px"}

                                            />

                                        </Card.Text>
                                    </Card.Body>
                                </Card>

                                <Card className={"m-2"} >
                                    <Card.Img
                                        variant={"top"}
                                        src={N7}
                                        height={"200"}
                                        width={"200"}
                                    />
                                    <Card.Body>
                                        <Card.Title style={{
                                            fontSize: "15px"
                                        }}> Republican Guy </Card.Title>
                                        <Card.Text>Патриотичный чел</Card.Text>
                                        <Button  variant={"outline-primary"} style={
                                            {
                                                borderRadius: "20px", marginBottom: "10px",
                                            }}>Купить</Button>
                                        <Card.Text className={"BTC"}>
                                            <FormText style={{textDecoration: "line-through", fontSize:"16.5px",
                                                color:"black", textDecorationColor:"red", textDecorationThickness:"3px"}}>100 </FormText>
                                            - 99
                                            <img
                                                src={"https://pngimg.com/uploads/bitcoin/small/bitcoin_PNG47.png"}
                                                height={"20px"}
                                                width={"20px"}

                                            />

                                        </Card.Text>
                                    </Card.Body>
                                </Card>
                                <Card className={"m-2"} >
                                    <Card.Img
                                        variant={"top"}
                                        src={N8}
                                        height={"200"}
                                        width={"200"}
                                    />
                                    <Card.Body>
                                        <Card.Title style={{
                                            fontSize: "15px"
                                        }}> Diarrhea Guy  </Card.Title>
                                        <Card.Text> Изящный чел </Card.Text>
                                        <Button variant={"outline-primary"} style={
                                            {
                                                borderRadius: "20px", marginBottom: "10px",
                                            }}>Купить</Button>
                                        <Card.Text className={"BTC"}>
                                            <FormText style={{textDecoration: "line-through", fontSize:"16.5px",
                                                color:"black", textDecorationColor:"red", textDecorationThickness:"3px"}}>0.24 </FormText>
                                            - 0.021
                                            <img
                                                src={"https://pngimg.com/uploads/bitcoin/small/bitcoin_PNG47.png"}
                                                height={"20px"}
                                                width={"20px"}

                                            />

                                        </Card.Text>
                                    </Card.Body>
                                </Card>

                            </Row>
                            </Tab.Pane>

                            <Tab.Pane eventKey={"two"}>
                                <Row md={"4"} style={{
                                    marginLeft: "100px",

                                }} >
                                    <Card className={"m-2"} >
                                        <Card.Img
                                            variant={"top"}
                                            src={N4}
                                            height={"200"}
                                            width={"200"}
                                        />
                                        <Card.Body>
                                            <Card.Title style={{
                                                fontSize: "15px"
                                            }}> Happy Jewish Guy </Card.Title>
                                            <Card.Text>Довольный чел</Card.Text>
                                            <Button  variant={"outline-primary"} style={
                                                {
                                                    borderRadius: "20px", marginBottom: "10px",
                                                }}>Купить</Button>
                                            <Card.Text className={"BTC"}>
                                                <FormText style={{textDecoration: "line-through", fontSize:"16.5px",
                                                    color:"black", textDecorationColor:"red", textDecorationThickness:"3px"}}>0.1 </FormText>
                                                - 2.91
                                                <img
                                                    src={"https://pngimg.com/uploads/bitcoin/small/bitcoin_PNG47.png"}
                                                    height={"20px"}
                                                    width={"20px"}

                                                />

                                            </Card.Text>
                                        </Card.Body>
                                    </Card>

                                    <Card className={"m-2"} >
                                        <Card.Img
                                            variant={"top"}
                                            src={N5}
                                            height={"200"}
                                            width={"200"}
                                        />
                                        <Card.Body>
                                            <Card.Title style={{
                                                fontSize: "15px"
                                            }}> Good Nice Guy </Card.Title>
                                            <Card.Text> Терпиливый чел</Card.Text>
                                            <Button  variant={"outline-primary"} style={
                                                {
                                                    borderRadius: "20px", marginBottom: "10px",
                                                }}>Купить</Button>
                                            <Card.Text className={"BTC"}>
                                                <FormText style={{textDecoration: "line-through", fontSize:"16.5px",
                                                    color:"black", textDecorationColor:"red", textDecorationThickness:"3px"}}>1 </FormText>
                                                - 0.00032
                                                <img
                                                    src={"https://pngimg.com/uploads/bitcoin/small/bitcoin_PNG47.png"}
                                                    height={"20px"}
                                                    width={"20px"}

                                                />

                                            </Card.Text>
                                        </Card.Body>
                                    </Card>
                                    <Card className={"m-2"} >
                                        <Card.Img
                                            variant={"top"}
                                            src={N9}
                                            height={"200"}
                                            width={"200"}
                                        />
                                        <Card.Body>
                                            <Card.Title style={{
                                                fontSize: "15px"
                                            }}> Beer Guy  </Card.Title>
                                            <Card.Text>Обозревающий чел</Card.Text>
                                            <Button variant={"outline-primary"} style={
                                                {
                                                    borderRadius: "20px", marginBottom: "10px",
                                                }}>Купить</Button>
                                            <Card.Text className={"BTC"}>
                                                <FormText style={{textDecoration: "line-through", fontSize:"16.5px",
                                                    color:"black", textDecorationColor:"red", textDecorationThickness:"3px"}}>1 </FormText>
                                                - 0.00051
                                                <img
                                                    src={"https://pngimg.com/uploads/bitcoin/small/bitcoin_PNG47.png"}
                                                    height={"20px"}
                                                    width={"20px"}

                                                />

                                            </Card.Text>
                                        </Card.Body>
                                    </Card>
                                    <Card className={"m-2"} >
                                        <Card.Img
                                            variant={"top"}
                                            src={N10}
                                            height={"200"}
                                            width={"200"}
                                        />
                                        <Card.Body>
                                            <Card.Title style={{
                                                fontSize: "15px"
                                            }}> Dancing Guy </Card.Title>
                                            <Card.Text>Танцующий чел</Card.Text>
                                            <Button  variant={"outline-primary"} style={
                                                {
                                                    borderRadius: "20px", marginBottom: "10px",
                                                }}>Купить</Button>
                                            <Card.Text className={"BTC"}>
                                                <FormText style={{textDecoration: "line-through", fontSize:"16.5px",
                                                    color:"black", textDecorationColor:"red", textDecorationThickness:"3px"}}>100 </FormText>
                                                - 14.88
                                                <img
                                                    src={"https://pngimg.com/uploads/bitcoin/small/bitcoin_PNG47.png"}
                                                    height={"20px"}
                                                    width={"20px"}

                                                />

                                            </Card.Text>
                                        </Card.Body>
                                    </Card>

                                    <Card className={"m-2"} >
                                        <Card.Img
                                            variant={"top"}
                                            src={N11}
                                            height={"200"}
                                            width={"200"}
                                        />
                                        <Card.Body>
                                            <Card.Title style={{
                                                fontSize: "15px"
                                            }}> Communist Guy </Card.Title>
                                            <Card.Text>Собачий чел</Card.Text>
                                            <Button  variant={"outline-primary"} style={
                                                {
                                                    borderRadius: "20px", marginBottom: "10px",
                                                }}>Купить</Button>
                                            <Card.Text className={"BTC"}>
                                                <FormText style={{textDecoration: "line-through", fontSize:"16.5px",
                                                    color:"black", textDecorationColor:"red", textDecorationThickness:"3px"}}>1 </FormText>
                                                - 0.0031
                                                <img
                                                    src={"https://pngimg.com/uploads/bitcoin/small/bitcoin_PNG47.png"}
                                                    height={"20px"}
                                                    width={"20px"}

                                                />

                                            </Card.Text>
                                        </Card.Body>
                                    </Card>
                                    <Card className={"m-2"} >
                                        <Card.Img
                                            variant={"top"}
                                            src={N12}
                                            height={"200"}
                                            width={"200"}
                                        />
                                        <Card.Body>
                                            <Card.Title style={{
                                                fontSize: "15px"
                                            }}> DDoS Guy  </Card.Title>
                                            <Card.Text>Дудосящий чел</Card.Text>
                                            <Button variant={"outline-primary"} style={
                                                {
                                                    borderRadius: "20px", marginBottom: "10px",
                                                }}>Купить</Button>
                                            <Card.Text className={"BTC"}>
                                                <FormText style={{textDecoration: "line-through", fontSize:"16.5px",
                                                    color:"black", textDecorationColor:"red", textDecorationThickness:"3px"}}>1 </FormText>
                                               - 0.072
                                                <img
                                                    src={"https://pngimg.com/uploads/bitcoin/small/bitcoin_PNG47.png"}
                                                    height={"20px"}
                                                    width={"20px"}

                                                />

                                            </Card.Text>
                                        </Card.Body>
                                    </Card>


                                </Row>
                            </Tab.Pane>

                            <Tab.Pane eventKey={"three"}>
                                <Row md={"4"} style={{
                                    marginLeft: "100px"
                                }} >
                                    <Card className={"m-2"} >
                                        <Card.Img
                                            variant={"top"}
                                            src={W1}
                                            height={"200"}
                                            width={"200"}
                                        />
                                        <Card.Body>
                                            <Card.Title style={{
                                                fontSize: "15px"
                                            }}> Left Guy </Card.Title>
                                            <Card.Text>Аэдринский чел</Card.Text>
                                            <Button  variant={"outline-primary"} style={
                                                {
                                                    borderRadius: "20px", marginBottom: "10px",
                                                }}>Купить</Button>
                                            <Card.Text className={"BTC"}>
                                                <FormText style={{textDecoration: "line-through", fontSize:"16.5px",
                                                    color:"black", textDecorationColor:"red", textDecorationThickness:"3px"}}>0.2 </FormText>
                                               - 0.001
                                                <img
                                                    src={"https://steamuserimages-a.akamaihd.net/ugc/1007063455495254696/D229A4D80A44425110E0DE8E66AA9978A1C6366C/"}
                                                    height={"20px"}
                                                    width={"20px"}

                                                />

                                            </Card.Text>
                                        </Card.Body>
                                    </Card>

                                    <Card className={"m-2"} >
                                        <Card.Img
                                            variant={"top"}
                                            src={W2}
                                            height={"200"}
                                            width={"200"}
                                        />
                                        <Card.Body>
                                            <Card.Title style={{
                                                fontSize: "15px"
                                            }}> Middle Guy </Card.Title>
                                            <Card.Text>Махакамский чел</Card.Text>
                                            <Button  variant={"outline-primary"} style={
                                                {
                                                    borderRadius: "20px", marginBottom: "10px",
                                                }}>Купить</Button>
                                            <Card.Text className={"BTC"}><FormText style={{textDecoration: "line-through", fontSize:"16.5px",
                                                color:"black", textDecorationColor:"red", textDecorationThickness:"3px"}}>0.04 </FormText>
                                                - 0.03
                                                <img
                                                    src={"https://steamuserimages-a.akamaihd.net/ugc/1007063455495254696/D229A4D80A44425110E0DE8E66AA9978A1C6366C/"}
                                                    height={"20px"}
                                                    width={"20px"}

                                                />

                                            </Card.Text>
                                        </Card.Body>
                                    </Card>
                                    <Card className={"m-2"} >
                                        <Card.Img
                                            variant={"top"}
                                            src={W3}
                                            height={"200"}
                                            width={"200"}
                                        />
                                        <Card.Body>
                                            <Card.Title style={{
                                                fontSize: "15px"
                                            }}> Right Guy </Card.Title>
                                            <Card.Text>Каэр Морхенский чел</Card.Text>
                                            <Button  variant={"outline-primary"} style={
                                                {
                                                    borderRadius: "20px", marginBottom: "10px",
                                                }}>Купить</Button>
                                            <Card.Text className={"BTC"}>
                                                <FormText style={{textDecoration: "line-through", fontSize:"16.5px",
                                                    color:"black", textDecorationColor:"red", textDecorationThickness:"3px"}}>0.03 </FormText>
                                                - 0.01
                                                <img
                                                    src={"https://steamuserimages-a.akamaihd.net/ugc/1007063455495254696/D229A4D80A44425110E0DE8E66AA9978A1C6366C/"}
                                                    height={"20px"}
                                                    width={"20px"}

                                                />

                                            </Card.Text>
                                        </Card.Body>
                                    </Card>

                                    <Card className={"m-2"} >
                                        <Card.Img
                                            variant={"top"}
                                            src={W4}
                                            height={"200"}
                                            width={"200"}
                                        />
                                        <Card.Body>
                                            <Card.Title style={{
                                                fontSize: "15px"
                                            }}> Redhead Lady </Card.Title>
                                            <Card.Text>Темерская дама</Card.Text>
                                            <Button  variant={"outline-primary"} style={
                                                {
                                                    borderRadius: "20px", marginBottom: "10px",
                                                }}>Купить</Button>
                                            <Card.Text className={"BTC"}>
                                                <FormText style={{textDecoration: "line-through", fontSize:"16.5px",
                                                    color:"black", textDecorationColor:"red", textDecorationThickness:"3px"}}>2.477 </FormText>
                                                - 1.51
                                                <img
                                                    src={"https://steamuserimages-a.akamaihd.net/ugc/1007063455495254696/D229A4D80A44425110E0DE8E66AA9978A1C6366C/"}
                                                    height={"20px"}
                                                    width={"20px"}

                                                />

                                            </Card.Text>
                                        </Card.Body>
                                    </Card>

                                    <Card className={"m-2"} >
                                        <Card.Img
                                            variant={"top"}
                                            src={W5}
                                            height={"200"}
                                            width={"200"}
                                        />
                                        <Card.Body>
                                            <Card.Title style={{
                                                fontSize: "15px"
                                            }}> Nilfgaardian Guy </Card.Title>
                                            <Card.Text>Нильфгаардский чел</Card.Text>
                                            <Button  variant={"outline-primary"} style={
                                                {
                                                    borderRadius: "20px", marginBottom: "10px",
                                                }}>Купить</Button>
                                            <Card.Text className={"BTC"}>
                                                <FormText style={{textDecoration: "line-through", fontSize:"16.5px",
                                                    color:"black", textDecorationColor:"red", textDecorationThickness:"3px"}}>98.5 </FormText>
                                                - 37.1
                                                <img
                                                    src={"https://steamuserimages-a.akamaihd.net/ugc/1007063455495254696/D229A4D80A44425110E0DE8E66AA9978A1C6366C/"}
                                                    height={"20px"}
                                                    width={"20px"}

                                                />

                                            </Card.Text>
                                        </Card.Body>
                                    </Card>
                                    <Card className={"m-2"} >
                                        <Card.Img
                                            variant={"top"}
                                            src={W6}
                                            height={"200"}
                                            width={"200"}
                                        />
                                        <Card.Body>
                                            <Card.Title style={{
                                                fontSize: "15px"
                                            }}> Nilfgaardian Lady  </Card.Title>
                                            <Card.Text>Цинтрийская дама</Card.Text>
                                            <Button variant={"outline-primary"} style={
                                                {
                                                    borderRadius: "20px", marginBottom: "10px",
                                                }}>Купить</Button>
                                            <Card.Text className={"BTC"}>
                                                <FormText style={{textDecoration: "line-through", fontSize:"16.5px",
                                                    color:"black", textDecorationColor:"red", textDecorationThickness:"3px"}}>2.41 </FormText>
                                                  - 1.351
                                                <img
                                                    src={"https://steamuserimages-a.akamaihd.net/ugc/1007063455495254696/D229A4D80A44425110E0DE8E66AA9978A1C6366C/"}
                                                    height={"20px"}
                                                    width={"20px"}

                                                />

                                            </Card.Text>
                                        </Card.Body>
                                    </Card>

                                </Row>
                            </Tab.Pane>

                        </Tab.Content>
                    </Col>
                </Row>

            </Tab.Container>
        </Container>


    </>
        );
    }
}

export default Sales;