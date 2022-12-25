
package com.sltc.soa.client.stub;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for anonymous complex type.
 * 
 * <p>The following schema fragment specifies the expected content contained within this class.
 * 
 * <pre>
 * &lt;complexType>
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="DepositMoneyResult" type="{http://www.w3.org/2001/XMLSchema}double"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "", propOrder = {
    "depositMoneyResult"
})
@XmlRootElement(name = "DepositMoneyResponse")
public class DepositMoneyResponse {

    @XmlElement(name = "DepositMoneyResult")
    protected double depositMoneyResult;

    /**
     * Gets the value of the depositMoneyResult property.
     * 
     */
    public double getDepositMoneyResult() {
        return depositMoneyResult;
    }

    /**
     * Sets the value of the depositMoneyResult property.
     * 
     */
    public void setDepositMoneyResult(double value) {
        this.depositMoneyResult = value;
    }

}
